using System.ComponentModel.DataAnnotations;

namespace Dof_Dot6Identity.Models.DTO
{
    public class LoginModel
    {
        [Required]
        public string Username { get; set; }
        [Required]   
        public string Password { get; set; }
    }
}
