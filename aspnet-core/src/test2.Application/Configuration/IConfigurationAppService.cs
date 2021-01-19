using System.Threading.Tasks;
using test2.Configuration.Dto;

namespace test2.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
