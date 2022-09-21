using Microsoft.EntityFrameworkCore;
using Movie.Data.Model.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Data.Access.Context
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options)
            : base(options)
        {
        }

        public DbSet<TblMovie> TblMovie { get; set; }
        public DbSet<TblMovieType> TblMovieType { get; set; }
        public DbSet<TblGeneralAudienceType> TblGeneralAudienceType { get; set; }
    }
}
