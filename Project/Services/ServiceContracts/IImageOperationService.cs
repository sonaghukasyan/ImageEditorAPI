using Project.Models.RequestModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Services.ServiceContracts
{
    public interface IImageOperationService
    {
        Task<byte[][]> EditImages(List<EditImageRequestModel> images);
    }
}
