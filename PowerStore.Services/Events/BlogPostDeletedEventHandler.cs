using System.Threading;
using System.Threading.Tasks;
using PowerStore.Domain.Blogs;
using PowerStore.Core.Events;
using PowerStore.Services.Seo;
using MediatR;

namespace PowerStore.Services.Events
{
    public class BlogPostDeletedEventHandler : INotificationHandler<EntityDeleted<BlogPost>>
    {
        private readonly IUrlRecordService _urlRecordService;
        
        public BlogPostDeletedEventHandler(IUrlRecordService urlRecordService)
        {
            _urlRecordService = urlRecordService;
        }
        public async Task Handle(EntityDeleted<BlogPost> notification, CancellationToken cancellationToken)
        {
            var urlToDelete = await _urlRecordService.GetBySlug(notification.Entity.SeName);
            await _urlRecordService.DeleteUrlRecord(urlToDelete);
        }
    }
}
