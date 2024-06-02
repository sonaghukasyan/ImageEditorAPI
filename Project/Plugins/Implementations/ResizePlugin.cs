using MessagePack;
using Project.Models.Enums;
using Project.Models.PluginModels;
using Project.Plugins.PluginComtracts;
using System.Threading.Tasks;

namespace Project.Plugins.Implementations
{
    public class ResizePlugin : IEditImagePlugin
    {
        public OperationType OperationType => OperationType.Resize;

        public byte[] ApplyOperation(byte[] image, byte[] parameters)
        {
            try
            {
                ResizeParameters resizeParameters = MessagePackSerializer.Deserialize<ResizeParameters>(parameters);

                if (resizeParameters != null)
                {
                    int width = resizeParameters.Width;
                    int height = resizeParameters.Height;

                    //add asynchronous logic to edit the image size/ if so add async await 
                    byte[] editedImage = new byte[image.Length];
                    return editedImage;
                }
            }
            catch
            {
                //log
            }

            return null;
        }
    }
}
