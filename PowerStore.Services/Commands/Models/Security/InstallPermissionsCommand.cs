using PowerStore.Services.Security;
using MediatR;

namespace PowerStore.Services.Commands.Models.Security
{
    public class InstallPermissionsCommand : IRequest<bool>
    {
        public IPermissionProvider PermissionProvider { get; set; }
    }
}
