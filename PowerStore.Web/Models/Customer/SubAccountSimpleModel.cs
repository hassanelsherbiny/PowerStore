using PowerStore.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace PowerStore.Web.Models.Customer
{
    public class SubAccountSimpleModel : BaseEntityModel
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Active { get; set; }
    }
}
