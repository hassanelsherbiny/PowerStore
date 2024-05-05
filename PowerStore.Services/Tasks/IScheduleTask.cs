using System.Threading.Tasks;

namespace PowerStore.Services.Tasks
{
    public interface IScheduleTask
    {
        Task Execute();
    }
}
