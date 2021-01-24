using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using test2.QLDM.DMTinhThanh;

namespace test2.DanhMuc.TinhThanhApp
{
    public interface ITinhThanhService: IApplicationService
    {
        Task<PagedResultDto<TinhThanhDto>> GetAll();
        Task Create(CreateTinhThanhDto input);
        Task DeleteAsync(EntityDto<int> input);
    }
}