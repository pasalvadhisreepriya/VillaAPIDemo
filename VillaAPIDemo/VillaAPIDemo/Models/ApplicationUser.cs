using Microsoft.AspNetCore.Identity;

namespace VillaAPIDemo.Models
{
    public class ApplicationUser :IdentityUser
    {
  public string Name { get; set; } 
    }
}
