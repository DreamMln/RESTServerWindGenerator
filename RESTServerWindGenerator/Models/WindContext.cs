using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTServerWindGenerator.Models
{
    public class WindContext : DbContext
    {
        //The constructor just calls the constructor in the DbContext class
        public WindContext(DbContextOptions<WindContext> options) : base(options) { }

        //We only have a single table with Wind which is represented by this DbSet
        public DbSet<Wind> Wind { get; set; }

        public WindContext()
        {
            //tom con
        }
    }
}
