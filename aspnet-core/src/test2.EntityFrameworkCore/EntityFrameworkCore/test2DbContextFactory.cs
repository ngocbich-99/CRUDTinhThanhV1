using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using test2.Configuration;
using test2.Web;

namespace test2.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class test2DbContextFactory : IDesignTimeDbContextFactory<test2DbContext>
    {
        public test2DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<test2DbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            Test2DbContextConfigurer.Configure(builder, configuration.GetConnectionString(test2Consts.ConnectionStringName));

            return new test2DbContext(builder.Options);
        }
    }
}
