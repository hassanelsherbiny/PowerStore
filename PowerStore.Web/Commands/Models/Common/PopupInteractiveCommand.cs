using MediatR;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace PowerStore.Web.Commands.Models.Common
{
    public class PopupInteractiveCommand : IRequest<IList<string>>
    {
        public IFormCollection Form { get; set; }
    }
}
