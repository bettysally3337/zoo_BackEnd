// Models/SampleDBContext.cs

using Microsoft.EntityFrameworkCore;
using MyBackend.Models;


namespace MyBackend.Data
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
    }
}