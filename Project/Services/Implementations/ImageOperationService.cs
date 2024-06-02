using Microsoft.AspNetCore.Mvc;
using Project.Managers.ServiceContracts;
using Project.Models.RequestModels;
using Project.Models.ResponseModels;
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

            foreach (EditImageRequestModel imageRequest in images)
            {
                tasks.Add(_pluginManager.ApplyEdits(imageRequest.Image, imageRequest.Operations));
            }

            byte[][] results = await Task.WhenAll(tasks);

            return results;
        }

        #endregion
    }
}
