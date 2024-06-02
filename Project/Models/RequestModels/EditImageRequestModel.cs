using MessagePack;
using System.Collections.Generic;

namespace Project.Models.RequestModels
{
    [MessagePackObject]
    public class EditImageRequestModel
    {
        /// <summary>
        /// Gets or sets the image which is in byte array format.
        /// </summary>
        [Key(0)]
        public byte[] Image { get; set; }

        /// <summary>
        /// Gets or sets the operations to apply to the image.
        /// </summary>
        [Key(1)]
        public List<Operation> Operations { get; set; }
    }
}
