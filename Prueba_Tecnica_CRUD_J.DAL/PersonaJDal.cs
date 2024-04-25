using Prueba_Tecnica_CRUD_J.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Prueba_Tecnica_CRUD_J.DAL
{
    public class PersonaJDal
    {
        public static async Task<PersonaJ> GetById(int id)
        {
            var user = new PersonaJ();
            using (var dbContext = new ComunDB())
            {
                user = await dbContext.PersonaJs.FirstOrDefaultAsync(p => p.Id == id);
            }
            return user;
        }
        public static async Task<int> Create(PersonaJ personaj)
        {
            int result = 0;
            using (var bdContext = new ComunDB())
            {
                bdContext.Add(personaj);
                result = await bdContext.SaveChangesAsync();
            }
            return result;
        }

        public static async Task<int> Update(PersonaJ personaj)
        {
            int result = 0;
            using (var bdContext = new ComunDB())
            {/*La "a" es el alias de la tabla*/
                var user = await bdContext.PersonaJs.FirstOrDefaultAsync(a => a.Id == personaj.Id);
                user.NombreJ = personaj.NombreJ;
                bdContext.Update(user);
                result = await bdContext.SaveChangesAsync();
            }
            return result;
        }

        public static async Task<int> Delete(PersonaJ personaj)
        {
            int result = 0;
            using (var bdContext = new ComunDB())
            {/*La "a" es el alias de la tabla*/
                var user = await bdContext.PersonaJs.FirstOrDefaultAsync(a => a.Id == personaj.Id);
                bdContext.Remove(user);
                result = await bdContext.SaveChangesAsync();
            }
            return result;
        }

        public static async Task<List<PersonaJ>> GetAll()
        {
            var user = new List<PersonaJ>();
            using (var dbContext = new ComunDB())
            {
                user = await dbContext.PersonaJs.ToListAsync();
            }
            return user;
        }
    }
}

