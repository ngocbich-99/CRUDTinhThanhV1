using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using test2.Authorization;
using test2.QLDM.DMTinhThanh;

namespace test2.DanhMuc.TinhThanhApp
{
    
    public class TinhThanhService : test2AppServiceBase , ITinhThanhService
    {
        private readonly IRepository<TinhThanh> _tinhThanhRepository;
    
        public TinhThanhService(IRepository<TinhThanh> tinhThanhRepository)
        {
            _tinhThanhRepository = tinhThanhRepository;
        }
    
        public async Task<PagedResultDto<TinhThanhDto>> GetAll()
        {
            //query viet theo linq, or lampda
            var tinhThanhs = await _tinhThanhRepository
                .GetAll()
                .ToListAsync();
            //lấy tất cả dữ liệu từ db
            var kq = new PagedResultDto<TinhThanhDto>();
            kq.TotalCount = tinhThanhs.Count;
            kq.Items = ObjectMapper.Map<List<TinhThanhDto>>(tinhThanhs);
            return kq;
        }
        
        public async Task Create(CreateTinhThanhDto input)
        {
            var tinhThanh = ObjectMapper.Map<TinhThanh>(input);
            await _tinhThanhRepository.InsertAsync(tinhThanh);
        }
        
        public async Task UpdateAsync(EditTTDto input)
        {
            
            var tinhThanh = await _tinhThanhRepository.GetAsync(input.Id);

            ObjectMapper.Map(input, tinhThanh);

            await _tinhThanhRepository.UpdateAsync(tinhThanh);
            
        }
        
        public async Task<GetTinhThanhForEditOutput> GetTTForEdit(EntityDto input)
        {
            var tinhThanh = await _tinhThanhRepository.GetAsync(input.Id);
            //map tinhthanh cho editTTDto
            var ttEditDto = ObjectMapper.Map<EditTTDto>(tinhThanh);

            return new GetTinhThanhForEditOutput   
            {
                Ma = ttEditDto.Ma,
                Ten = ttEditDto.Ten,
                GhiChu = ttEditDto.GhiChu,
            };
        }

        public async Task DeleteAsync(EntityDto<int> input)
        {
            var tinhThanh = await _tinhThanhRepository.FirstOrDefaultAsync(input.Id);
            await _tinhThanhRepository.DeleteAsync(tinhThanh);
        }
    }

   // [AbpAuthorize(PermissionNames.Pages_TinhThanh)]
    // public class TinhThanhService : CrudAppService<TinhThanh, TinhThanhDto>
    // {
    //     public TinhThanhService(IRepository<TinhThanh, int> repository) : base(repository)
    //     {
    //     }
    // }
}