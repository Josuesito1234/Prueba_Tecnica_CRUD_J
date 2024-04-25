using Prueba_Tecnica_CRUD_J.EN;
using Prueba_Tecnica_CRUD_J.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Tecnica_CRUD_J.BL
{
    public class PersonaJBL
    {
        public static async Task<PersonaJ> GetById(int id)
        {
            return await PersonaJDal.GetById(id);
        }
        public static async Task<List<PersonaJ>> GetAll()
        {
            return await PersonaJDal.GetAll();
        }
        public static async Task<int> Create(PersonaJ personaj)
        {
            return await PersonaJDal.Create(personaj);
        }
        public static async Task<int> Update(PersonaJ personaj)
        {
            return await PersonaJDal.Update(personaj);
        }
        public static async Task<int> Delete(PersonaJ personaj)
        {
            return await PersonaJDal.Delete(personaj);
        }
    }
}
