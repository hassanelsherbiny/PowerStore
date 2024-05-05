using PowerStore.Services.Customers;
using System.Threading.Tasks;

namespace PowerStore.Services.Tasks
{
    public partial class CustomerReminderBirthdayScheduleTask : IScheduleTask
    {
        private readonly ICustomerReminderService _customerReminderService;

        public CustomerReminderBirthdayScheduleTask(ICustomerReminderService customerReminderService)
        {
            _customerReminderService = customerReminderService;
        }

        public async Task Execute()
        {
            await _customerReminderService.Task_Birthday();
        }
    }
}
