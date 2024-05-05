using MediatR;

namespace PowerStore.Services.Commands.Models.Catalog
{
    public class DeleteMeasureUnitOnProductCommand : IRequest<bool>
    {
        public string MeasureUnitId { get; set; }
    }
}
