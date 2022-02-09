using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace CounselingCenter.Api.Entities
{
    public class AppUser : IdentityUser
    {
        [StringLength(20)] public string FirstName { get; set; }
        [StringLength(20)] public string LastName { get; set; }
    }
}