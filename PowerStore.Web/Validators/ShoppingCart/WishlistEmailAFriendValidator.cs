using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Models.ShoppingCart;
using System.Collections.Generic;

namespace PowerStore.Web.Validators.ShoppingCart
{
    public class WishlistEmailAFriendValidator : BasePowerStoreValidator<WishlistEmailAFriendModel>
    {
        public WishlistEmailAFriendValidator(
            IEnumerable<IValidatorConsumer<WishlistEmailAFriendModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.FriendEmail).NotEmpty().WithMessage(localizationService.GetResource("Wishlist.EmailAFriend.FriendEmail.Required"));
            RuleFor(x => x.FriendEmail).EmailAddress().WithMessage(localizationService.GetResource("Common.WrongEmail"));

            RuleFor(x => x.YourEmailAddress).NotEmpty().WithMessage(localizationService.GetResource("Wishlist.EmailAFriend.YourEmailAddress.Required"));
            RuleFor(x => x.YourEmailAddress).EmailAddress().WithMessage(localizationService.GetResource("Common.WrongEmail"));
        }}
}