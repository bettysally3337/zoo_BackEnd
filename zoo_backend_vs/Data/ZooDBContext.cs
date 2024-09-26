// Models/SampleDBContext.cs

using Microsoft.EntityFrameworkCore;
using zoo_backend_vs.Models;
using zoo_backend_vs.Models;


namespace zoo_backend_vs.Data
{
    public partial class ZooDBContext : DbContext
    {
        public ZooDBContext(DbContextOptions
        <ZooDBContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Animals> Animals { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Animals>(entity =>
        //    {
        //        entity.HasKey(k => k.A_Name_Ch);
        //    });
        //    OnModelCreatingPartial(modelBuilder);
        //}
        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public virtual DbSet<Area> Area { get; set; }

        public virtual DbSet<Plants> Plant { get; set; }

        public virtual DbSet<ServiceSpot> serviceSpot { get; set; }
    }
}