using WebApplication2.Models;

namespace WebApplication2.Services
{
    public interface IComp
    {
        Task<List<Comp>> GetComp();
        Task<Comp> GetById(int id);
        Task<List<Comp>> CreateComp(Comp newComp);
        Task<List<Comp>> UpdateComp(Comp updateComp);
        Task<List<Comp>> DeleteComp(int id);

    }
}
