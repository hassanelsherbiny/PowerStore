#! "netcoreapp3.1"
#r "PowerStore.Core"
#r "PowerStore.Framework"
#r "PowerStore.Services"
#r "PowerStore.Web"

using System;
using PowerStore.Domain.Messages;
using PowerStore.Domain.Orders;
using PowerStore.Services.Events;
using PowerStore.Services.Notifications.Messages;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using PowerStore.Core;

/* Sample code to add new token message (message email) to the order */

public class OrderTokenTest : INotificationHandler<EntityTokensAddedEvent<Order>>
{
    public Task Handle(EntityTokensAddedEvent<Order> eventMessage, CancellationToken cancellationToken)
    {
        //in message templates you can put new token {{AdditionalTokens["NewOrderNumber"]}}
        eventMessage.LiquidObject.AdditionalTokens.Add("NewOrderNumber", $"{eventMessage.Entity.CreatedOnUtc.Year}/{eventMessage.Entity.OrderNumber}");
        return Task.CompletedTask;
    }

}



