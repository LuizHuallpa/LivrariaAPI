using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace LivrariaAPI.Models
{
    public class ToDoContext : DbContext
    {

        public ToDoContext(DbContextOptions<ToDoContext> option) : base(option)
        {

        }

        public DbSet<Produto> TodoProducts { get; set; }
    }
}
