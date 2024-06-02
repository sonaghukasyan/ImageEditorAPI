using Project.Models.Enums;
using Project.Models.PluginModels;
using Project.Plugins.PluginComtracts;

namespace Project.Plugins.Implementations
{
    public class BlurPlugin : IEditImagePlugin
    {
        public OperationType OperationType => OperationType.Blur;

        public byte[] ApplyOperation(byte[] image, object parameters)
        {
            BlurParameters blurParameters = parameters as BlurParameters;

            if(blurParameters != null)
            {
                int radius = blurParameters.Radius;

                //add asynchronous logic to edit the image size/ if so add async await 
                //await blurImage(radius) --> ApplyOperation becomes async
                byte[] editedImage = new byte[image.Length];
                return editedImage;
            }

            return null;
        }
    }
}
