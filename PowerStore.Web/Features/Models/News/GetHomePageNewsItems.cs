using PowerStore.Web.Models.News;
using MediatR;

namespace PowerStore.Web.Features.Models.News
{
    public class GetHomePageNewsItems : IRequest<HomePageNewsItemsModel>
    {
    }
}
