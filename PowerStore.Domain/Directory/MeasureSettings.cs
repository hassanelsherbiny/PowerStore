using PowerStore.Domain.Configuration;

namespace PowerStore.Domain.Directory
{
    public class MeasureSettings : ISettings
    {
        public string BaseDimensionId { get; set; }
        public string BaseWeightId { get; set; }
    }
}