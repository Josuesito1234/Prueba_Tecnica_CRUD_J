using Prueba_Tecnica_CRUD_J.EN;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Prueba_Tecnica_CRUD_J.DAL
{
    public class ComunDB : DbContext
    { 
            public DbSet<PersonaJ> PersonaJs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-NFDMETJ\\SQLEXPRESS; Initial Catalog = JDB; Integrated Security = True; Trust Server Certificate = True");
        }
        
    }
}
