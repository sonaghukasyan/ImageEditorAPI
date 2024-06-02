using MessagePack;

namespace Project.Models.PluginModels
{
    [MessagePackObject]
    public class BlurParameters
    {
        [Key(0)]
        public double Radius { get; set; }
    }
}
