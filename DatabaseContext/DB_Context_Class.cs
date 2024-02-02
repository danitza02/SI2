using Microsoft.EntityFrameworkCore;
using DatabaseEntityLib;
using System.Reflection.Emit;

namespace DataBaseContext
{
    public class DB_Context_Class : DbContext
    {
        public DbSet<Predmet> Predmet { get; set; }

        public DbSet<Oblast> Oblast { get; set; }

        public DbSet<Pitanja> Pitanja { get; set; }




        public DB_Context_Class(DbContextOptions<DB_Context_Class> options) : base(options)
        {

        }


    }
}