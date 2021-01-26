using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace test2.QLDM.DMTinhThanh
{
    [AutoMapFrom(typeof(TinhThanh))]
    public class TinhThanhDto : EntityDto<int>
    {
        [Required]
        public string Ma { get; set; }
        [Required]
        public string Ten { get; set; }
        public string GhiChu { get; set; }
    }
}