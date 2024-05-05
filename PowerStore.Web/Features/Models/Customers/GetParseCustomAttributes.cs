using PowerStore.Domain.Common;
using MediatR;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace PowerStore.Web.Features.Models.Customers
{
    public class GetParseCustomAttributes : IRequest<IList<CustomAttribute>>
    {
        public IFormCollection Form { get; set; }
    }
}
