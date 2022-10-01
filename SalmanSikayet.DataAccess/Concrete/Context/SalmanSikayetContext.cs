using Microsoft.EntityFrameworkCore;
using SalmanSikayet.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalmanSikayet.DataAccess.Concrete.Context
{
    public class SalmanSikayetContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"bağlantı cümlesi");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Complaint> Complaints
        {
            get; set;
        }
    }
}
