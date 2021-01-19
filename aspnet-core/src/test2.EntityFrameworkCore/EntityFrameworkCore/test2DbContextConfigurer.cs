using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace test2.EntityFrameworkCore
{
    public static class Test2DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<test2DbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<test2DbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
