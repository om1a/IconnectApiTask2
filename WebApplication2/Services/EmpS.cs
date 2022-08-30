using WebApplication2.Models;
namespace WebApplication2.Services
{
    public class EmpS:IEmp
    {
        private static List<Emp> Empp = new List<Emp>
        {
            new Emp
                {
                    Id = 1,
                    Name = "Alaa",
                    Age = 24,
                    CompId="1"
                },new Emp
                {
                    Id = 2,
                    Name = "Omar",
                    Age = 23,
                    CompId="1"
                }
            };
        public async Task<List<Emp>> CreateEmp(Emp newEmp)
        {
            Empp.Add(newEmp);
            return (Empp);
        }

        public async Task<List<Emp>> DeleteEmp(int id)
        {
            Emp Emplo = Empp.First(x => x.Id == id);
            Empp.Remove(Emplo);
            return (Empp);
        }

        public async Task<List<Emp>> GetEmp()
        {
            return Empp;
        }

        public async Task<Emp> GetById(int id)
        {
            return (Empp.First(x => x.Id == id));
        }

        public async Task<List<Emp>> UpdateEmp(Emp updateEmp)
        {
            Emp Emplo = Empp.First(x => x.Id == updateEmp.Id);
            Emplo.Id= updateEmp.Id;
            Emplo.Name = updateEmp.Name;
            Emplo.Age = updateEmp.Age;
            Emplo.CompId = updateEmp.CompId;

            return Empp;
        }
    }
}
