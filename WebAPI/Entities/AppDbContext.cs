using Microsoft.EntityFrameworkCore;

namespace WebAPI.Entities
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Player> Members { get; set; }
        public DbSet<TrophyRegister> TrophyRegister { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<InOutRegister> InOutRegisters { get; set; }
        public DbSet<ClubFamily> ClubFamilies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Player>(entity =>
            {
                entity.HasKey(m => m.Id);
                entity.HasOne(m => m.Club).WithMany(c => c.Members).HasForeignKey(m => m.ClubId).OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<TrophyRegister>(entity =>
            {
                entity.HasKey(t => t.Id);
                entity.HasOne(t => t.Member).WithMany(m => m.Registers).HasForeignKey(t => t.MemberId);
            });

            modelBuilder.Entity<Club>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.HasOne(c => c.Family).WithMany(c => c.Clubs).HasForeignKey(c => c.FamilyId).OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<InOutRegister>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.HasOne(r => r.Club).WithMany(c => c.InOuts).HasForeignKey(r => r.ClubId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(r => r.Member).WithMany(m => m.InOuts).HasForeignKey(r => r.MemberId);
            });

            modelBuilder.Entity<ClubFamily>(entity =>
            {
                entity.HasKey(c => c.Id);
            });
        }

    }
}
