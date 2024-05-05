using PowerStore.Api.DTOs.Catalog;
using PowerStore.Api.Extensions;
using PowerStore.Domain.Catalog;
using PowerStore.Services.Catalog;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Api.Commands.Models.Catalog
{
    public class AddProductAttributeMappingCommandHandler : IRequestHandler<AddProductAttributeMappingCommand, ProductAttributeMappingDto>
    {
        private readonly IProductAttributeService _productAttributeService;

        public AddProductAttributeMappingCommandHandler(IProductAttributeService productAttributeService)
        {
            _productAttributeService = productAttributeService;
        }

        public async Task<ProductAttributeMappingDto> Handle(AddProductAttributeMappingCommand request, CancellationToken cancellationToken)
        {
            //insert mapping
            var productAttributeMapping = request.Model.ToEntity();
            productAttributeMapping.ProductId = request.Product.Id;
            await _productAttributeService.InsertProductAttributeMapping(productAttributeMapping);

            return productAttributeMapping.ToModel();
        }
    }
}
