﻿using PowerStore.Domain.Documents;
using PowerStore.Services.Catalog;
using PowerStore.Services.Customers;
using PowerStore.Services.Documents;
using PowerStore.Services.Localization;
using PowerStore.Services.Orders;
using PowerStore.Services.Shipping;
using PowerStore.Services.Vendors;
using PowerStore.Web.Areas.Admin.Extensions;
using PowerStore.Web.Areas.Admin.Interfaces;
using PowerStore.Web.Areas.Admin.Models.Documents;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerStore.Web.Areas.Admin.Services
{
    public class DocumentViewModelService : IDocumentViewModelService
    {
        private readonly IDocumentService _documentService;
        private readonly IDocumentTypeService _documentTypeService;
        private readonly ICustomerService _customerService;
        private readonly IOrderService _orderService;
        private readonly ILocalizationService _localizationService;
        private readonly IProductService _productService;
        private readonly IShipmentService _shipmentService;
        private readonly IReturnRequestService _returnRequestService;
        private readonly ICategoryService _categoryService;
        private readonly IManufacturerService _manufacturerService;
        private readonly IVendorService _vendorService;
        private readonly ISalesEmployeeService _salesEmployeeService;

        public DocumentViewModelService(
            IDocumentService documentService,
            IDocumentTypeService documentTypeService,
            ICustomerService customerService,
            IOrderService orderService,
            ILocalizationService localizationService,
            IProductService productService,
            IShipmentService shipmentService,
            IReturnRequestService returnRequestService,
            ICategoryService categoryService,
            IManufacturerService manufacturerService,
            IVendorService vendorService,
            ISalesEmployeeService salesEmployeeService
            )
        {
            _documentService = documentService;
            _documentTypeService = documentTypeService;
            _customerService = customerService;
            _orderService = orderService;
            _localizationService = localizationService;
            _productService = productService;
            _shipmentService = shipmentService;
            _returnRequestService = returnRequestService;
            _categoryService = categoryService;
            _manufacturerService = manufacturerService;
            _vendorService = vendorService;
            _salesEmployeeService = salesEmployeeService;
        }

        public virtual async Task<(IEnumerable<DocumentModel> documetListModel, int totalCount)> PrepareDocumentListModel(DocumentListModel model, int pageIndex, int pageSize)
        {
            var documents = await _documentService.GetAll(customerId: "", name: model.SearchName, number: model.SearchNumber,
                email: model.SearchEmail, reference: model.Reference, objectId: model.ObjectId, status: model.StatusId, pageIndex: pageIndex - 1, pageSize: pageSize);

            var documentListModel = new List<DocumentModel>();
            foreach (var x in documents)
            {
                var docModel = x.ToModel();
                documentListModel.Add(docModel);
            }
            return (documentListModel, documents.TotalCount);
        }

        public virtual async Task<DocumentModel> PrepareDocumentModel(DocumentModel documentModel, Document document, SimpleDocumentModel simpleModel)
        {
            var model = documentModel == null ? new DocumentModel() { Published = true } : documentModel;
            if (document != null)
                model = document.ToModel();
            else
            {
                if (simpleModel != null)
                {
                    model.ReferenceId = simpleModel.Reference;
                    model.ObjectId = simpleModel.ObjectId;
                    if (!string.IsNullOrEmpty(simpleModel.CustomerId))
                        model.CustomerEmail = (await _customerService.GetCustomerById(simpleModel.CustomerId))?.Email;

                    if (!string.IsNullOrEmpty(simpleModel.ObjectId))
                        switch (simpleModel.Reference)
                        {
                            case (int)Reference.Order:
                                var order = await _orderService.GetOrderById(simpleModel.ObjectId);
                                if (order != null)
                                {
                                    model.Number = order.OrderNumber.ToString();
                                    model.TotalAmount = order.OrderTotal;
                                    model.OutstandAmount = order.PaymentStatus == Domain.Payments.PaymentStatus.Paid ? 0 : order.OrderTotal;
                                    model.CurrencyCode = order.CustomerCurrencyCode;
                                    model.Name = string.Format(_localizationService.GetResource("Order.Document"), model.Number);
                                    model.DocDate = order.CreatedOnUtc;
                                    model.DueDate = order.CreatedOnUtc;
                                    model.Quantity = 1;
                                    model.Username = $"{order.BillingAddress?.FirstName} {order.BillingAddress?.LastName}";
                                    model.CustomerEmail = order.CustomerEmail;
                                }
                                break;
                            case (int)Reference.Product:
                                var product = await _productService.GetProductById(simpleModel.ObjectId);
                                if (product != null)
                                {
                                    model.Name = product.Name;
                                    model.Number = product.Sku;
                                    model.Quantity = 1;
                                }
                                break;
                            case (int)Reference.Category:
                                var category = await _categoryService.GetCategoryById(simpleModel.ObjectId);
                                if (category != null)
                                {
                                    model.Name = category.Name;
                                    model.Quantity = 1;
                                }
                                break;
                            case (int)Reference.Manufacturer:
                                var manufacturer = await _manufacturerService.GetManufacturerById(simpleModel.ObjectId);
                                if (manufacturer != null)
                                {
                                    model.Name = manufacturer.Name;
                                    model.Quantity = 1;
                                }
                                break;
                            case (int)Reference.Vendor:
                                var vendor = await _vendorService.GetVendorById(simpleModel.ObjectId);
                                if (vendor != null)
                                {
                                    model.Name = vendor.Name;
                                    model.Quantity = 1;
                                }
                                break;
                            case (int)Reference.Shipment:
                                var shipment = await _shipmentService.GetShipmentById(simpleModel.ObjectId);
                                if (shipment != null)
                                {
                                    model.DocDate = shipment.CreatedOnUtc;
                                    model.Number = shipment.ShipmentNumber.ToString();
                                    model.Name = string.Format(_localizationService.GetResource("Shipment.Document"), shipment.ShipmentNumber);
                                    var sorder = await _orderService.GetOrderById(shipment.OrderId);
                                    if (sorder != null)
                                    {
                                        model.CustomerId = sorder.CustomerId;
                                        model.CustomerEmail = sorder.CustomerEmail;
                                    }
                                }
                                break;
                            case (int)Reference.ReturnRequest:
                                var returnrequest = await _returnRequestService.GetReturnRequestById(simpleModel.ObjectId);
                                if (returnrequest != null)
                                {
                                    model.DocDate = returnrequest.CreatedOnUtc;
                                    model.Number = returnrequest.ReturnNumber.ToString();
                                    model.Name = string.Format(_localizationService.GetResource("ReturnRequests.Document"), returnrequest.ReturnNumber);
                                    var sorder = await _orderService.GetOrderById(returnrequest.OrderId);
                                    if (sorder != null)
                                    {
                                        model.CustomerId = sorder.CustomerId;
                                        model.CustomerEmail = sorder.CustomerEmail;
                                    }
                                }
                                break;
                        }
                }
            }
            //fill document types
            var types = await _documentTypeService.GetAll();
            foreach (var item in types)
            {
                model.AvailableDocumentTypes.Add(new SelectListItem {
                    Text = item.Name,
                    Value = item.Id
                });
            }

            //fill sales employees
            model.AvailableSelesEmployees.Add(new SelectListItem {
                Text = _localizationService.GetResource("Admin.Documents.Document.Fields.SeId.None"),
                Value = ""
            });
            var salesEmployees = await _salesEmployeeService.GetAll();
            foreach (var item in salesEmployees.Where(x => x.Active))
            {
                model.AvailableSelesEmployees.Add(new SelectListItem {
                    Text = item.Name,
                    Value = item.Id
                });

            }
            return model;
        }

    }
}
