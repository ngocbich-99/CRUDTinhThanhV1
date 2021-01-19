using Abp.Application.Services;
using test2.MultiTenancy.Dto;

namespace test2.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

