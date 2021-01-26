using Abp.AutoMapper;

namespace test2.QLDM.DMTinhThanh
{
    //mapfrom
    [AutoMap(typeof(TinhThanh))]
    
    public class EditTTDto
    {
        public int Id { get; set;}
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string GhiChu { get; set; }
    }
}