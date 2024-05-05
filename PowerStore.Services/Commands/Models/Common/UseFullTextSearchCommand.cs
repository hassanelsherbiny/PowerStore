using MediatR;

namespace PowerStore.Services.Commands.Models.Common
{
    public class UseFullTextSearchCommand : IRequest<bool>
    {
        public bool UseFullTextSearch { get; set; }
    }
}
