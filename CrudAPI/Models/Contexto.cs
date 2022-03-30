using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CrudAPI.Models
{
    public class Contexto : DbContext
    {
        public DbSet<User> Users { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            
        }
    }
}