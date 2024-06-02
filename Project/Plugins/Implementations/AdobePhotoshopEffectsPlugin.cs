using Project.Models.Enums;
using Project.Models.PluginModels;
using Project.Plugins.PluginComtracts;

namespace Project.Plugins.Implementations
{
    public class AdobePhotoshopEffectsPlugin : IEditImagePlugin
    {
        public OperationType OperationType => OperationType.AdobePhotoshopEffects;

        public byte[] ApplyOperation(byte[] image, object parameters)
        {
            AdobePhotoshopEffectParameters adobeParameters = parameters as AdobePhotoshopEffectParameters;

            if (adobeParameters != null)
            {
                AdobeEffect effect = adobeParameters.Effect;

                //add asynchronous logic to edit the image size/ if so add async await 
                //await apply effect --> method becomes async
                byte[] editedImage = new byte[image.Length];
                return editedImage;
            }

            return null;
        }
    }
}
