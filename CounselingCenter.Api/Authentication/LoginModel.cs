using System.ComponentModel.DataAnnotations;

namespace CounselingCenter.Api.Authentication
{
    public class LoginModel
    {
        [Required] public string Email { get; set; }
        [Required] public string Password { get; set; }
    }
}