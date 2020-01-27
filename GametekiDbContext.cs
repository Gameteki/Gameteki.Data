namespace CrimsonDev.Gameteki.Data
{
    using System;
    using CrimsonDev.Gameteki.Data.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class GametekiDbContext : IdentityDbContext<GametekiUser, GametekiRole, string,
        IdentityUserClaim<string>, GametekiUserRole, IdentityUserLogin<string>,
        IdentityRoleClaim<string>, IdentityUserToken<string>>, IGametekiDbContext
    {
        public GametekiDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected GametekiDbContext()
        {
        }

        public DbSet<News> News { get; set; }
        public DbSet<RefreshToken> RefreshToken { get; set; }
        public DbSet<BlockListEntry> BlockListEntry { get; set; }
        public DbSet<LobbyMessage> LobbyMessage { get; set; }

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
                role.HasIndex(r => r.NormalizedName).HasName("RoleNameIndex").IsUnique();
                role.Property(r => r.ConcurrencyStamp).IsConcurrencyToken();
                role.Property(r => r.Name).HasMaxLength(256);
                role.Property(r => r.NormalizedName).HasMaxLength(256);

                role.HasMany<GametekiUserRole>().WithOne(ur => ur.Role).HasForeignKey(ur => ur.RoleId);
                role.HasMany<IdentityRoleClaim<string>>().WithOne().HasForeignKey(rc => rc.RoleId);
            });

            builder.Entity<IdentityRoleClaim<string>>(roleClaim =>
            {
                roleClaim.HasKey(rc => rc.Id);
                roleClaim.ToTable("RoleClaims");
            });

            builder.Entity<GametekiUserRole>(userRole =>
            {
                userRole.ToTable("UserRoles");
                userRole.HasKey(r => new { r.UserId, r.RoleId });
            });

            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");
        }
    }
}
