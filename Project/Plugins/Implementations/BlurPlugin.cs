using MessagePack;
using Project.Models.Enums;
using Project.Models.PluginModels;
using Project.Plugins.PluginComtracts;

namespace Project.Plugins.Implementations
{
    public class BlurPlugin : IEditImagePlugin
    {
        public OperationType OperationType => OperationType.Blur;

        public byte[] ApplyOperation(byte[] image, byte[] parameters)
        {
            try
            {
                BlurParameters blurParams = MessagePackSerializer.Deserialize<BlurParameters>(parameters);

                if (blurParams != null)
                {
                    double effect = blurParams.Radius;

                    //add asynchronous logic to edit the image size/ if so add async await 
                    //await apply effect --> method becomes async
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
