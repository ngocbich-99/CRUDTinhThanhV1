using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using test2.QLDM.DMTinhThanh;

namespace test2.DanhMuc.TinhThanhApp
{
    public interface ITinhThanhService: IApplicationService
    {
        Task<ListResultDto<TinhThanhDto>> GetAll(TinhThanhDto dto);
    }
}