using VillaAPIDemo.Models.DTO;
using VillaAPIDemo.Models;
using VillaAPIDemo_Web.Models.DTO;

namespace VillaAPIDemo.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        Task<UserDTO> Register(RegisterationRequestDTO registerationRequestDTO);
    }
}
