using MessagePack;

namespace Project.Models.PluginModels
{
    [MessagePackObject]
    public class ResizeParameters 
    {
        [Key(0)]
        public int Width { get; set; }

        [Key(1)]
        public int Height { get; set; }
    }
}
