using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;

namespace test2.QLDM.DMTinhThanh
{
    [AutoMapTo(typeof(TinhThanh))]
    public class CreateTinhThanhDto
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string GhiChu { get; set; }
        
    }
}