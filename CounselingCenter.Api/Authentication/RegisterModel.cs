using System.ComponentModel.DataAnnotations;

namespace CounselingCenter.Api.Authentication
{
    public class RegisterModel
    {
        [EmailAddress] [Required] public string Email { get; set; }
        [Required] public string FirstName { get; set; }
        [Required] public string LastName { get; set; }
        [Required] public string Password { get; set; }
    }
}