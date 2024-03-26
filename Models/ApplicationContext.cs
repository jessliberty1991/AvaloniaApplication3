using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AvaloniaApplication3.Models
{
    class ApplicationContext:DbContext
    {
        public DbSet<Place> places { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {

            dbContextOptionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\AvaloniaApplication3\Data1.mdf;Integrated Security=True");

        }
    }
}
