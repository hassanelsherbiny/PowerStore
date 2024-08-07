﻿using PowerStore.Domain.Catalog;
using PowerStore.Domain.Customers;
using PowerStore.Domain.Directory;
using PowerStore.Domain.Stores;
using PowerStore.Web.Models.Catalog;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace PowerStore.Web.Features.Models.Products
{
    public class GetProductDetailsAttributeChange : IRequest<ProductDetailsAttributeChangeModel>
    {
        public Customer Customer { get; set; }
        public Currency Currency { get; set; }
        public Store Store { get; set; }
        public Product Product { get; set; }
        public bool ValidateAttributeConditions { get; set; }
        public bool LoadPicture { get; set; }
        public IFormCollection Form { get; set; }
    }
}
