using VillaApi.Models;

namespace VillaApi.Repository.IRepository
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {

        Task<VillaNumber> UpdateAsync(VillaNumber entity);

    }
}
