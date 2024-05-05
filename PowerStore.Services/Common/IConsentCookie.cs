using System.Threading.Tasks;

namespace PowerStore.Services.Common
{
    public interface IConsentCookie
    {
        string SystemName { get; }
        bool AllowToDisable { get; }
        bool? DefaultState { get; }
        int DisplayOrder { get; }
        Task<string> Name();
        Task<string> FullDescription();
    }
}
