using System.ComponentModel.DataAnnotations;

namespace test2.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}