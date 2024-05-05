using PowerStore.Domain.Admin;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PowerStore.Services.Admin
{
    public interface IAdminSiteMapService
    {
        Task<IList<AdminSiteMap>> GetSiteMap();
    }
}
