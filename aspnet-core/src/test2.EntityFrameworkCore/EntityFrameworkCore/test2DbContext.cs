using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using test2.Authorization.Roles;
using test2.Authorization.Users;
using test2.MultiTenancy;
using test2.QLDM.DMTinhThanh;

namespace test2.EntityFrameworkCore
{
    public class test2DbContext : AbpZeroDbContext<Tenant, Role, User, test2DbContext>
    {
        public DbSet<TinhThanh> TinhThanhs { get; set; }
        /* Define a DbSet for each entity of the application */
        
        public test2DbContext(DbContextOptions<test2DbContext> options)
            : base(options)
        {
        }
    }
}
