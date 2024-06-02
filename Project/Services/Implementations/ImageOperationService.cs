using Microsoft.AspNetCore.Mvc;
using Project.Managers.ServiceContracts;
using Project.Models.RequestModels;
using Project.Services.ServiceContracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Services.Implementations
{
    public class ImageOperationService : IImageOperationService
    {
        #region Variables

        private IPluginManager _pluginManager;

        #endregion

        #region Constructors

        public ImageOperationService(IPluginManager pluginManager)
        {
            _pluginManager = pluginManager;
        }

        #endregion

        #region Methods

        public async Task<byte[][]> EditImages(List<EditImageRequestModel> images)
        {
            List<Task<byte[]>> tasks = new List<Task<byte[]>>();

            try
            {
                foreach (EditImageRequestModel imageRequest in images)
                {
                    if (imageRequest.Image != null && imageRequest.Operations != null)
                    {
                        tasks.Add(_pluginManager.ApplyEdits(imageRequest.Image, imageRequest.Operations));
                    }
                }

                byte[][] results = await Task.WhenAll(tasks);

                return results;
            }
            catch
            {
                //log
            }

            return null;
        }

        #endregion
    }
}
