using Project.Models.RequestModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Managers.ServiceContracts
{
    public interface IPluginManager
    {
        Task<byte[]> ApplyEdits(byte[] image, List<Operation> operations);
    }
}
