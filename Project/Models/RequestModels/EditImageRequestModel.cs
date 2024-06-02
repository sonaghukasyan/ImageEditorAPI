using System.Collections.Generic;

namespace Project.Models.RequestModels
{
    public class EditImageRequestModel
    {
        public byte[] Image { get; set; }

        public List<Operation> Operations { get; set; }
    }
}
