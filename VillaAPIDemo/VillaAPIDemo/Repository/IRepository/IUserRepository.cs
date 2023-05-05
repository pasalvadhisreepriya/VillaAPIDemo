using VillaAPIDemo.Models.DTO;
using VillaAPIDemo.Models;
namespace VillaAPIDemo.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        Task<LocalUser> Register(RegisterationRequestDTO registerationRequestDTO);
    }
}
