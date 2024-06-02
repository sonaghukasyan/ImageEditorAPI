using MessagePack;
using Project.Models.Enums;

namespace Project.Models.RequestModels
{
    [MessagePackObject]
    public class Operation
    {
        /// <summary>
        /// Gets or sets the type of the operation.
        /// </summary>
        [Key(0)]
        public OperationType OperationType { get; set; }

        /// <summary>
        /// Gets or sets the parameters which are messagepack serialized into byte array.
        /// </summary>
        /// <value>
        /// The parameters.
        /// </value>
        [Key(1)]
        public byte[] Parameters { get; set; }
    }
}
