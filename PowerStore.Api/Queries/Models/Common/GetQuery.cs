using MediatR;
using MongoDB.Driver.Linq;

namespace PowerStore.Api.Queries.Models.Common
{
    public class GetQuery<T> : IRequest<IMongoQueryable<T>> where T : class
    {
        public string Id { get; set; }
    }
}
