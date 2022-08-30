using WebApplication2.Models;

namespace WebApplication2.Services
{
    public class CompS:IComp
    {
        private static List<Comp> Company = new List<Comp>
        {
            new Comp
                {
                    Id = 1,
                    Name = "Iconnect",
                    Location="Ram-allah"
            },new Comp
                {
                    Id = 2,
                    Name = "Asal",
                    Location = "Tulkarem"
                }
            };
        public async Task<List<Comp>> CreateComp(Comp newComp)
        {
            Company.Add(newComp);
            return (Company);
        }

        public async Task<List<Comp>> DeleteComp(int id)
        {
            Comp cM = Company.First(x => x.Id == id);
            Company.Remove(cM);
            return (Company);
        }

        public async Task<List<Comp>> GetComp()
        {
            return Company;
        }

        public async Task<Comp> GetById(int id)
        {
            return (Company.First(x => x.Id == id));
        }

        /**/
        /**/

        public async Task<Comp> UpdateComp(Comp updateComp)
        {
            Comp tG = Company.First(x => x.Id == updateComp.Id);
            tG.Name = updateComp.Name;
            tG.Location = updateComp.Location;
            tG.Id = updateComp.Id;

            return tG;
        }
    }

}
