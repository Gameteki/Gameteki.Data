namespace CrimsonDev.Gameteki.Data
{
    using System;
    using System.Linq;
    using CrimsonDev.Gameteki.Data.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;

    public class GametekiDbContext : DbContext, IGametekiDbContext
    {
        public GametekiDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected GametekiDbContext()
        {
        }

        public DbSet<News> News { get; set; }
        public DbSet<BlockListEntry> BlockListEntry { get; set; }
        public DbSet<LobbyMessage> LobbyMessage { get; set; }
        public DbSet<PatreonToken> PatreonToken { get; set; }
        public DbSet<GametekiUser> Users { get; set; }
        public DbSet<GametekiRole> Roles { get; set; }
        public DbSet<GametekiUserRole> UserRoles { get; set; }

        public void SetModified<TEntity>(TEntity entity)
            where TEntity : class
        {
            Entry(entity).State = EntityState.Modified;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            base.OnModelCreating(builder);

            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            builder.Entity<GametekiUser>(b =>
            {
                b.ToTable("Users");
                b.Property(u => u.Id).ValueGeneratedOnAdd();
                b.HasMany(u => u.UserRoles).WithOne(ur => ur.User).HasForeignKey(ur => ur.UserId).IsRequired();
                b.OwnsOne(user => user.Settings, settings =>
                {
                    settings.Property(s => s.Background).HasDefaultValue("BG1");
                    settings.Property(s => s.CardSize).HasDefaultValue("normal");
                });
            });

            builder.Entity<GametekiRole>(role =>
            {
                role.ToTable("Roles");
                role.HasKey(r => r.Id);
                role.Property(u => u.Id).ValueGeneratedOnAdd();
                role.Property(r => r.Name).HasMaxLength(256);

                role.HasMany<GametekiUserRole>().WithOne(ur => ur.Role).HasForeignKey(ur => ur.RoleId);
            });

            builder.Entity<GametekiUserRole>(userRole =>
            {
                userRole.ToTable("UserRoles");
                userRole.HasKey(r => new { r.UserId, r.RoleId });
            });

            builder.Entity<PatreonToken>().HasKey(pt => pt.Id);
        }
    }
}
