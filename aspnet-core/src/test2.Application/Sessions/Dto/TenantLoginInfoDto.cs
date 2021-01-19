using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using test2.MultiTenancy;

namespace test2.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
