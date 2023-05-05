using Microsoft.Identity.Client;

namespace VillaAPIDemo.Models.DTO
{
    public class LoginResponseDTO
    {
        public LocalUser User {get; set;}
        public string Token { get; set; }

    }
}
