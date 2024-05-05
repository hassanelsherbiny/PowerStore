using PowerStore.Domain.Catalog;
using PowerStore.Domain.Common;
using MediatR;
using System.Collections.Generic;

namespace PowerStore.Services.Commands.Models.Catalog
{
    public class SendNotificationsToSubscribersCommand : IRequest<IList<BackInStockSubscription>>
    {
        public Product Product { get; set; }
        public IList<CustomAttribute> Attributes { get; set; }
        public string Warehouse { get; set; }
    }
}
