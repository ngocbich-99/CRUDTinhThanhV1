using System.Threading.Tasks;
using test2.Models.TokenAuth;
using test2.Web.Controllers;
using Shouldly;
using Xunit;

namespace test2.Web.Tests.Controllers
{
    public class HomeController_Tests: test2WebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}