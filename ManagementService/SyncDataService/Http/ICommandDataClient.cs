using System.Threading.Tasks;
using ManagementService.Dtos;

namespace ManagementService.SyncDataService.Http
{
    public interface ICommandDataClient
    {
        Task SendManagementToCommand(ClassReadDto cl);
    }
}