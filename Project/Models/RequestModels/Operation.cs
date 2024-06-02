using Project.Models.Enums;

namespace Project.Models.RequestModels
{
    public class Operation
    {
        public OperationType OperationType { get; set; }

        public object Parameters { get; set; }
    }
}
