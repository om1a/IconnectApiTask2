using WebApplication2.Models;

namespace WebApplication2.Services
{
    public interface IEmp
    {
        Task<List<Emp>> GetEmp();
        Task<Emp> GetById(int id);
        Task<List<Emp>> CreateEmp(Emp newEmp);
        Task<List<Emp>> UpdateEmp(Emp updateEmp);
        Task<List<Emp>> DeleteEmp(int id);
    }
}
