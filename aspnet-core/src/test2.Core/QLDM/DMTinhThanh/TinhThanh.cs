using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace test2.QLDM.DMTinhThanh
{
    // [AutoMapFrom(typeof(CreateTinhThanhDto))]

    public class TinhThanh: Entity<int>
    
    {
        [Required]
        public string Ma { get; set; } 
        [Required]
        public string Ten { get; set; } 
        public string GhiChu { get; set; }
    }
}