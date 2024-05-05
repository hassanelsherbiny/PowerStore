using PowerStore.Domain.Catalog;
using PowerStore.Domain.Common;
using MediatR;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace PowerStore.Web.Features.Models.ShoppingCart
{
    public class GetParseProductAttributes : IRequest<IList<CustomAttribute>>
    {
        public Product Product { get; set; }
        public IFormCollection Form { get; set; }
    }
}
