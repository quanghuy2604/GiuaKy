using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace BookMovie.Models
{
    public class EFDdataContext : DbContext
    {
        public EFDdataContext(DbContextOptions<EFDdataContext> options)
               : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {    
            modelBuilder.Entity<DatVe>().HasKey(s => s.sdt);
            modelBuilder.Entity<Phim>().HasKey(s => s.tenphim);
            modelBuilder.Entity<Rap>().HasKey(s => s.tenrap);
            modelBuilder.Entity<LichChieu>().HasKey(s => s.idLC);

        }



        public DbSet<Phim> Phims { get; set; }
        public DbSet<Rap> Raps { get; set; }
        public DbSet<DatVe> DatVes { get; set; }
        public DbSet<LichChieu> LichChieus { get; set; }
    }
}
