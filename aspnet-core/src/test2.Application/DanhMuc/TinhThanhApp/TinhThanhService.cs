using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using test2.Authorization;
using test2.QLDM.DMTinhThanh;

namespace test2.DanhMuc.TinhThanhApp
{
    
    // public class TinhThanhService : test2AppServiceBase , ITinhThanhService
    // {
    //     private readonly IRepository<TinhThanh> _tinhThanhRepository;
    //
    //     public TinhThanhService(IRepository<TinhThanh> tinhThanhRepository)
    //     {
    //         _tinhThanhRepository = tinhThanhRepository;
    //     }
    //
    //     public async Task<ListResultDto<TinhThanhDto>> GetAll(TinhThanhDto dto)
    //     {
    //         //query viet theo linq, or lampda
    //         var tinhThanhs = await _tinhThanhRepository
    //             .GetAll()
    //             .ToListAsync();
    //         //lấy tất cả dữ liệu từ db
    //         
    //         return new ListResultDto<TinhThanhDto>(
    //             ObjectMapper.Map<List<TinhThanhDto>>(tinhThanhs));
    //     }
    // }

   // [AbpAuthorize(PermissionNames.Pages_TinhThanh)]
    public class TinhThanhService : CrudAppService<TinhThanh, TinhThanhDto>
    {
        public TinhThanhService(IRepository<TinhThanh, int> repository) : base(repository)
        {
        }
    }
}