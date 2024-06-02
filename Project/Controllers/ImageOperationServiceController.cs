using Microsoft.AspNetCore.Mvc;
using Project.Models.RequestModels;
using Project.Services.ServiceContracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImageOperationServiceController : Controller
    {
        #region Variables

        private static IImageOperationService _imageOperationService;

        #endregion

        #region Constructors
        public ImageOperationServiceController(IImageOperationService imageOperationService)
        {
            _imageOperationService = imageOperationService;
        }

        #endregion

        #region Methods       

        /// <summary>
        /// Edits the images.
        /// </summary>
        /// <param name="request">The request which contains images and operations that need to be applied.</param>
        /// <returns>Returns all edited images.</returns>
        [HttpPost("EditImages")]
        public async Task<byte[][]> EditImages([FromBody] List<EditImageRequestModel> request)
        {
            return await _imageOperationService.EditImages(request);
        }

        #endregion
    }
}
