using Abp.Domain.Entities;

namespace test2.QLDM.DMTinhThanh
{
    public class TinhThanh: Entity<int>

    {
    public string Ma { get; set; }
    public string Ten { get; set; }
    public string GhiChu { get; set; }
    }
}