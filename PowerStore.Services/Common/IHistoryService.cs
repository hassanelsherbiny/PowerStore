using PowerStore.Domain;
using PowerStore.Domain.History;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PowerStore.Services.Common
{
    /// <summary>
    /// History service interface
    /// </summary>
    public partial interface IHistoryService
    {
        Task SaveObject<T>(T entity) where T : BaseEntity;
        Task<IList<T>> GetHistoryForEntity<T>(BaseEntity entity) where T : BaseEntity;
        Task<IList<HistoryObject>> GetHistoryObjectForEntity(BaseEntity entity);
    }
}