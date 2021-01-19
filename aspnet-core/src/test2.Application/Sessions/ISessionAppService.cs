using System.Threading.Tasks;
using Abp.Application.Services;
using test2.Sessions.Dto;

namespace test2.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
