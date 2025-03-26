using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RentMovies.Domain.Entities;

namespace RentMovies.Ifraestructure
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<RentMovies.Domain.Entities.Movie> Movies { get; set; } = default!;
        public DbSet<RentMovies.Domain.Entities.Category> Categories { get; set; } = default!;

    }
}
