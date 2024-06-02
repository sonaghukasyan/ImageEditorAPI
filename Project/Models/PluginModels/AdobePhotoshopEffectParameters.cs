using MessagePack;
using Project.Models.Enums;

namespace Project.Models.PluginModels
{
    [MessagePackObject]
    public class AdobePhotoshopEffectParameters
    {
        [Key(0)]
        public AdobeEffect Effect { get; set; }
    }
}
