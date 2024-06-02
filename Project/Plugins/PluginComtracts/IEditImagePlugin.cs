using Project.Models.Enums;
using Project.Models.PluginModels;

namespace Project.Plugins.PluginComtracts
{
    public interface IEditImagePlugin
    {
        OperationType OperationType { get; }

        byte[] ApplyOperation(byte[] image, byte[] parameters);
    }
}
