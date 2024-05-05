using PowerStore.Domain.Blogs;
using PowerStore.Domain.Catalog;
using PowerStore.Domain.Customers;
using PowerStore.Domain.Knowledgebase;
using PowerStore.Domain.Localization;
using PowerStore.Domain.Messages;
using PowerStore.Domain.News;
using PowerStore.Domain.Orders;
using PowerStore.Domain.Shipping;
using PowerStore.Domain.Stores;
using PowerStore.Domain.Vendors;
using System.Threading.Tasks;

namespace PowerStore.Services.Messages
{
    public partial interface IMessageTokenProvider
    {
        Task AddStoreTokens(LiquidObject liquidObject, Store store, Language language, EmailAccount emailAccount);
        Task AddOrderTokens(LiquidObject liquidObject, Order order, Customer customer, Store store, OrderNote orderNote = null, Vendor vendor = null, decimal refundedAmount = 0);
        Task AddShipmentTokens(LiquidObject liquidObject, Shipment shipment, Order order, Store store, Language language);
        Task AddRecurringPaymentTokens(LiquidObject liquidObject, RecurringPayment recurringPayment);
        Task AddReturnRequestTokens(LiquidObject liquidObject, ReturnRequest returnRequest, Store store, Order orderItem, Language language, ReturnRequestNote returnRequestNote = null);
        Task AddGiftCardTokens(LiquidObject liquidObject, GiftCard giftCard, Language language);
        Task AddCustomerTokens(LiquidObject liquidObject, Customer customer, Store store, Language language, CustomerNote customerNote = null);
        Task AddShoppingCartTokens(LiquidObject liquidObject, Customer customer, Store store, Language language, string personalMessage = "", string customerEmail = "");
        Task AddVendorTokens(LiquidObject liquidObject, Vendor vendor, Language language);
        Task AddNewsLetterSubscriptionTokens(LiquidObject liquidObject, NewsLetterSubscription subscription, Store store);
        Task AddProductReviewTokens(LiquidObject liquidObject, Product product, ProductReview productReview);
        Task AddVendorReviewTokens(LiquidObject liquidObject, Vendor vendor, VendorReview VendorReview);
        Task AddBlogCommentTokens(LiquidObject liquidObject, BlogPost blogPost, BlogComment blogComment, Store store, Language language);
        Task AddArticleCommentTokens(LiquidObject liquidObject, KnowledgebaseArticle article, KnowledgebaseArticleComment articleComment, Store store, Language language);
        Task AddNewsCommentTokens(LiquidObject liquidObject, NewsItem newsItem, NewsComment newsComment, Store store, Language language);
        Task AddProductTokens(LiquidObject liquidObject, Product product, Language language, Store store);
        Task AddAttributeCombinationTokens(LiquidObject liquidObject, Product product, ProductAttributeCombination combination);
        Task AddBackInStockTokens(LiquidObject liquidObject, Product product, BackInStockSubscription subscription, Store store, Language language);
        Task AddAuctionTokens(LiquidObject liquidObject, Product product, Bid bid);
        string[] GetListOfCampaignAllowedTokens();
        string[] GetListOfAllowedTokens();
        string[] GetListOfCustomerReminderAllowedTokens(CustomerReminderRuleEnum rule);
    }
}