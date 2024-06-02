using Microsoft.OpenApi.Models;

namespace Project.Models.ResponseModels
{
    public class EditImageResponseModel
    {
        public byte[] EditedImage { get; set; }

        public OperationType OperationType { get; set; }
    }
}
