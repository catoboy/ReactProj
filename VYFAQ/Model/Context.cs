using Microsoft.EntityFrameworkCore;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VYFAQ.Model
{
    public class Context : DbContext 
    {
        public Context(DbContextOptions<Context> options)
        : base(options) { }
        public DbSet<QA> QandA { get; set; }

    }
}
