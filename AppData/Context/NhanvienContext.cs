using AppData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Context
{
    public class NhanvienContext : DbContext
    {

        public NhanvienContext()
        {
            
        }
        public NhanvienContext(DbContextOptions options): base(options)
        {
        }
        public DbSet<NhanVien> NhanViens { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-PTN36F3\\SQLEXPRESS;Initial Catalog=bttlab56;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
