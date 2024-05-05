using PowerStore.Services.Customers;
using System.Threading.Tasks;

namespace PowerStore.Services.Tasks
{
    public partial class CustomerReminderUnpaidOrderScheduleTask : IScheduleTask
    {
        private readonly ICustomerReminderService _customerReminderService;
        public CustomerReminderUnpaidOrderScheduleTask(ICustomerReminderService customerReminderService)
        {
            _customerReminderService = customerReminderService;
        }

        public async Task Execute()
        {
            await _customerReminderService.Task_UnpaidOrder();
        }
    }
}
