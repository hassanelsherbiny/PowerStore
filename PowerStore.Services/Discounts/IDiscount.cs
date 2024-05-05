using PowerStore.Core.Plugins;
using System.Collections.Generic;

namespace PowerStore.Services.Discounts
{
    /// <summary>
    /// Represents a discount requirement rule
    /// </summary>
    public partial interface IDiscount : IPlugin
    {
        IList<IDiscountRequirementRule> GetRequirementRules();
    }
}
