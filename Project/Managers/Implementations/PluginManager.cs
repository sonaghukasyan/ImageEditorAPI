using Project.Managers.ServiceContracts;
using Project.Models.Enums;
using Project.Models.RequestModels;
using Project.Plugins.Implementations;
using Project.Plugins.PluginComtracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Managers.Implementations
{
    public class PluginManager : IPluginManager
    {
        #region Variables

        private static readonly Dictionary<OperationType, IEditImagePlugin> _pluginServices = new Dictionary<OperationType, IEditImagePlugin>();

        #endregion

        #region Constructors

        public PluginManager(ResizePlugin resizePlugin, BlurPlugin blurPlugin, AdobePhotoshopEffectsPlugin photoshopEffectsPlugin)
        {
            _pluginServices.Add(OperationType.Resize, resizePlugin);
            _pluginServices.Add(OperationType.Blur, blurPlugin);
            _pluginServices.Add(OperationType.AdobePhotoshopEffects, photoshopEffectsPlugin);
        }

        #endregion

        #region Methods

        public async Task<byte[]> ApplyEdits(byte[] image, List<Operation> operations)
        {
            try
            {
                foreach (Operation operation in operations)
                {
                    if (_pluginServices.TryGetValue(operation.OperationType, out IEditImagePlugin editImagePlugin))
                    {
                        if(operation.Parameters != null)
                        {
                            //in reality should be awaited
                            image = editImagePlugin.ApplyOperation(image, operation.Parameters);
                        }
                    }
                }
            }
            catch
            {
                //lof
            }

            return image;
        }

        #endregion
    }
}
