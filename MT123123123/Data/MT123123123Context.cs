using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MT123123123.Models
{
    public class MT123123123Context : DbContext
    {
        public MT123123123Context (DbContextOptions<MT123123123Context> options)
            : base(options)
        {
        }

        public DbSet<MT123123123.Models.Message> Message { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Message>().HasData(new Message { Id = 1, Name = "Billy Bob", Msg = "Hi all y'alls" },
                new Message { Id = 2, Name = "Sally Joe", Msg = "Hi" });
        }
    }
}
