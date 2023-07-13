using System.ComponentModel.DataAnnotations;

namespace API_with_JWT_Authentication.Models
{
    public class AddRoleModel
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        public string Role { get; set; }

    }
}
