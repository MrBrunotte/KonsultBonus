using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonsultBonus.Models
{
    public class Context : DbContext
    {
        public DbSet<Konsulter> konsulter { get; set; }
        public Context(DbContextOptions<Context> options)
            :base(options)
        {

        }
    }
}
