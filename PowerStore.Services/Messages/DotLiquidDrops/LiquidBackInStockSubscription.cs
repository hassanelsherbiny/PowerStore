﻿using DotLiquid;
using PowerStore.Domain.Catalog;
using PowerStore.Domain.Localization;
using PowerStore.Domain.Stores;
using PowerStore.Services.Seo;
using System.Collections.Generic;

namespace PowerStore.Services.Messages.DotLiquidDrops
{
    public partial class LiquidBackInStockSubscription : Drop
    {
        private readonly BackInStockSubscription _backInStockSubscription;
        private readonly Product _product;
        private readonly Store _store;
        private readonly Language _language;

        public LiquidBackInStockSubscription(Product product, BackInStockSubscription backInStockSubscription, Store store, Language language)
        {
            _backInStockSubscription = backInStockSubscription;
            _product = product;
            _store = store;
            _language = language;

            AdditionalTokens = new Dictionary<string, string>();
        }

        public string ProductName {
            get { return _product.Name; }
        }

        public string AttributeInfo {
            get { return _backInStockSubscription.AttributeInfo; }
        }

        public string ProductUrl {
            get { return string.Format("{0}{1}", _store.SslEnabled ? _store.SecureUrl : _store.Url, _product.GetSeName(_language.Id)); }
        }

        public IDictionary<string, string> AdditionalTokens { get; set; }
    }
}