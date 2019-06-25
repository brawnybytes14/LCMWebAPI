using LCMWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCMWebAPI.Data
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<History> Histories { get; set; }
        public DbSet<AlgorithmType> AlgorithmTypes { get; set; }
        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
