using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

        public class ApplicationConnect : DbContext
        {
            public DbSet<Cinema> Avtoriz { get; set; } = null!;
            public DbSet<Movie> Tools { get; set; } = null!;

            public ApplicationConnect()
            {
                Database.EnsureCreated();
            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseMySql("server=mysql80.hostland.ru;user=host1849318_kondratiev;password=qwerty123!;database=host1849318_kondratiev;",
                    new MySqlServerVersion(new Version(8, 0, 25)));
            }

        }