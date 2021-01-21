using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace test2.QLDM.DMTinhThanh
{
    [AutoMapFrom(typeof(TinhThanh))]
    public class TinhThanhDto : EntityDto<int>
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string GhiChu { get; set; }
    }
}