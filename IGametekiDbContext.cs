namespace CrimsonDev.Gameteki.Data
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using CrimsonDev.Gameteki.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Infrastructure;

    public interface IGametekiDbContext : IDisposable
    {
        DbSet<News> News { get; set; }
        DbSet<GametekiUser> Users { get; set; }
        DbSet<RefreshToken> RefreshToken { get; set; }
        DbSet<BlockListEntry> BlockListEntry { get; set; }
        DbSet<GametekiUserRole> UserRoles { get; set; }
        DbSet<GametekiRole> Roles { get; set; }

        DatabaseFacade Database { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));

        void SetModified<TEntity>(TEntity entity)
            where TEntity : class;
    }
 }
