using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using test2.Roles.Dto;
using test2.Users.Dto;

namespace test2.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}
