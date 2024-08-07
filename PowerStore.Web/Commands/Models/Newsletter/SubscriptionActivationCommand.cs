﻿using PowerStore.Web.Models.Newsletter;
using MediatR;
using System;

namespace PowerStore.Web.Commands.Models.Newsletter
{
    public class SubscriptionActivationCommand : IRequest<SubscriptionActivationModel>
    {
        public Guid Token { get; set; }
        public bool Active { get; set; }
    }
}
