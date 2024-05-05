using PowerStore.Api.Commands.Models.Catalog;
using PowerStore.Services.Catalog;
using PowerStore.Services.Localization;
using PowerStore.Services.Logging;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
namespace PowerStore.Api.Commands.Handlers.Catalog
{
    public class DeleteSpecificationAttributeCommandHandler : IRequestHandler<DeleteSpecificationAttributeCommand, bool>
    {
        private readonly ISpecificationAttributeService _specificationAttributeService;
        private readonly ICustomerActivityService _customerActivityService;
        private readonly ILocalizationService _localizationService;

        public DeleteSpecificationAttributeCommandHandler(
            ISpecificationAttributeService specificationAttributeService,
            ICustomerActivityService customerActivityService,
            ILocalizationService localizationService)
        {
            _specificationAttributeService = specificationAttributeService;
            _customerActivityService = customerActivityService;
            _localizationService = localizationService;
        }

        public async Task<bool> Handle(DeleteSpecificationAttributeCommand request, CancellationToken cancellationToken)
        {
            var specificationAttribute = await _specificationAttributeService.GetSpecificationAttributeById(request.Model.Id);
            if (specificationAttribute != null)
            {
                await _specificationAttributeService.DeleteSpecificationAttribute(specificationAttribute);
                //activity log
                await _customerActivityService.InsertActivity("DeleteSpecAttribute", specificationAttribute.Id, _localizationService.GetResource("ActivityLog.DeleteSpecAttribute"), specificationAttribute.Name);
            }
            return true;
        }
    }
}
