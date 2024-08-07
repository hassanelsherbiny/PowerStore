﻿using PowerStore.Domain.Catalog;
using PowerStore.Domain.Common;
using PowerStore.Domain.Customers;
using PowerStore.Domain.Orders;
using PowerStore.Services.Customers;
using PowerStore.Services.Notifications.Customers;
using PowerStore.Services.Notifications.Orders;
using PowerStore.Services.Notifications.ShoppingCart;
using PowerStore.Services.Orders;
using PowerStore.Services.Payments;
using MediatR;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PowerStore.Services.Events.Extensions
{
    public static class WebEventsExtensions
    {
        public static async Task ShoppingCartWarningsAdd<T, U>(this IMediator eventPublisher, IList<T> warnings, IList<U> shoppingCartItems, List<CustomAttribute> checkoutAttributes, bool validateCheckoutAttributes) where U : ShoppingCartItem
        {
            await eventPublisher.Publish(new ShoppingCartWarningsEvent<T, U>(warnings, shoppingCartItems, checkoutAttributes, validateCheckoutAttributes));
        }

        public static async Task ShoppingCartItemWarningsAdded<C, S, P>(this IMediator eventPublisher, IList<string> warnings, C customer, S shoppingcartItem, P product) where C : Customer where S : ShoppingCartItem where P : Product
        {
            await eventPublisher.Publish(new ShoppingCartItemWarningsEvent<C, S, P>(warnings, customer, shoppingcartItem, product));
        }

        public static async Task CustomerRegistrationEvent<C, R>(this IMediator eventPublisher, C result, R request) where C : CustomerRegistrationResult where R : CustomerRegistrationRequest
        {
            await eventPublisher.Publish(new CustomerRegistrationEvent<C, R>(result, request));
        }

        public static async Task PlaceOrderDetailsEvent<R, O>(this IMediator eventPublisher, R result, O order) where R : PlaceOrderResult where O : PlaceOrderContainter
        {
            await eventPublisher.Publish(new PlaceOrderDetailsEvent<R, O>(result, order));
        }
        public static async Task CaptureOrderDetailsEvent<R, C>(this IMediator eventPublisher, R result, C request) where R : CapturePaymentResult where C : CapturePaymentRequest
        {
            await eventPublisher.Publish(new CaptureOrderDetailsEvent<R, C>(result, request));
        }
        public static async Task VoidOrderDetailsEvent<R, C>(this IMediator eventPublisher, R result, C request) where R : VoidPaymentResult where C : VoidPaymentRequest
        {
            await eventPublisher.Publish(new VoidOrderDetailsEvent<R, C>(result, request));
        }
    }
}
