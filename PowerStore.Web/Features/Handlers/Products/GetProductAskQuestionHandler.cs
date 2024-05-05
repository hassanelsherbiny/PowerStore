using PowerStore.Domain.Customers;
using PowerStore.Framework.Security.Captcha;
using PowerStore.Services.Common;
using PowerStore.Services.Customers;
using PowerStore.Services.Localization;
using PowerStore.Services.Seo;
using PowerStore.Web.Features.Models.Products;
using PowerStore.Web.Models.Catalog;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Web.Features.Handlers.Products
{
    public class GetProductAskQuestionHandler : IRequestHandler<GetProductAskQuestion, ProductAskQuestionModel>
    {
        private readonly CaptchaSettings _captchaSettings;

        public GetProductAskQuestionHandler(CaptchaSettings captchaSettings)
        {
            _captchaSettings = captchaSettings;
        }

        public async Task<ProductAskQuestionModel> Handle(GetProductAskQuestion request, CancellationToken cancellationToken)
        {
            var model = new ProductAskQuestionModel();
            model.Id = request.Product.Id;
            model.ProductName = request.Product.GetLocalized(x => x.Name, request.Language.Id);
            model.ProductSeName = request.Product.GetSeName(request.Language.Id);
            model.Email = request.Customer.Email;
            model.FullName = request.Customer.GetFullName();
            model.Phone = request.Customer.GetAttributeFromEntity<string>(SystemCustomerAttributeNames.Phone);
            model.Message = "";
            model.DisplayCaptcha = _captchaSettings.Enabled && _captchaSettings.ShowOnAskQuestionPage;

            return await Task.FromResult(model);
        }
    }
}
