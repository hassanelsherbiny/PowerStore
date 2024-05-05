using PowerStore.Domain.Catalog;
using MediatR;

namespace PowerStore.Services.Commands.Models.Catalog
{
    public class UpdateIntervalPropertiesCommand : IRequest<bool>
    {
        public Product Product { get; set; }
        public int Interval { get; set; }
        public IntervalUnit IntervalUnit { get; set; }
        public bool IncludeBothDates { get; set; }
    }
}
