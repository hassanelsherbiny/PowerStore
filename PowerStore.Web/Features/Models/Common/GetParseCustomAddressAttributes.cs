using PowerStore.Domain.Common;
using MediatR;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace PowerStore.Web.Features.Models.Common
{
    public class GetParseCustomAddressAttributes : IRequest<IList<CustomAttribute>>
    {
        public IFormCollection Form { get; set; }
    }
}
