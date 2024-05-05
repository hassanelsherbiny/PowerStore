using PowerStore.Core;
using PowerStore.Services.Helpers;
using PowerStore.Services.Security;
using PowerStore.Services.Topics;
using PowerStore.Web.Extensions;
using PowerStore.Web.Features.Models.Topics;
using PowerStore.Web.Models.Topics;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Web.Features.Handlers.Topics
{
    public class GetTopicBlockHandler : IRequestHandler<GetTopicBlock, TopicModel>
    {
        private readonly ITopicService _topicService;
        private readonly IWorkContext _workContext;
        private readonly IStoreContext _storeContext;
        private readonly IAclService _aclService;
        private readonly IDateTimeHelper _dateTimeHelper;

        public GetTopicBlockHandler(
            ITopicService topicService,
            IWorkContext workContext,
            IStoreContext storeContext,
            IAclService aclService, 
            IDateTimeHelper dateTimeHelper)
        {
            _topicService = topicService;
            _workContext = workContext;
            _storeContext = storeContext;
            _aclService = aclService;
            _dateTimeHelper = dateTimeHelper;
        }

        public async Task<TopicModel> Handle(GetTopicBlock request, CancellationToken cancellationToken)
        {
            //load by store
            var topic = string.IsNullOrEmpty(request.TopicId) ?
                await _topicService.GetTopicBySystemName(request.SystemName, _storeContext.CurrentStore.Id) :
                await _topicService.GetTopicById(request.TopicId);

            if (topic == null || !topic.Published)
                return null;

            if ((topic.StartDateUtc.HasValue && topic.StartDateUtc > DateTime.UtcNow) || (topic.EndDateUtc.HasValue && topic.EndDateUtc < DateTime.UtcNow))
                return null;

            //ACL (access control list)
            if (!_aclService.Authorize(topic))
                return null;

            return topic.ToModel(_workContext.WorkingLanguage, _dateTimeHelper, request.Password);

        }
    }
}
