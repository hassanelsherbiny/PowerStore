using PowerStore.Services.Commands.Models.Messages;
using PowerStore.Services.Directory;
using PowerStore.Services.Localization;
using PowerStore.Services.Messages.DotLiquidDrops;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Services.Commands.Handlers.Messages
{
    public class GetVendorTokensCommandHandler : IRequestHandler<GetVendorTokensCommand, LiquidVendor>
    {
        private readonly ICountryService _countryService;
        private readonly IStateProvinceService _stateProvinceService;

        public GetVendorTokensCommandHandler(
            ICountryService countryService, 
            IStateProvinceService stateProvinceService)
        {
            _countryService = countryService;
            _stateProvinceService = stateProvinceService;
        }

        public async Task<LiquidVendor> Handle(GetVendorTokensCommand request, CancellationToken cancellationToken)
        {
            var liquidVendor = new LiquidVendor(request.Vendor);
            liquidVendor.StateProvince = !string.IsNullOrEmpty(request.Vendor.Address?.StateProvinceId) ?
                (await _stateProvinceService.GetStateProvinceById(request.Vendor.Address.StateProvinceId))?
                .GetLocalized(x => x.Name, request.Language.Id) : "";
            liquidVendor.Country = !string.IsNullOrEmpty(request.Vendor.Address?.CountryId) ?
                (await _countryService.GetCountryById(request.Vendor.Address.CountryId))?
                .GetLocalized(x => x.Name, request.Language.Id) : "";

            return liquidVendor;
        }
    }
}
