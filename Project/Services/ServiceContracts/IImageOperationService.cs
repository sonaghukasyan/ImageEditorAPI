using Microsoft.AspNetCore.Mvc;
using Project.Models.RequestModels;
using Project.Models.ResponseModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Services.ServiceContracts
{
    public interface IImageOperationService
    {
        Task<byte[][]> EditImages(List<EditImageRequestModel> images);
    }
}
