using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data;

public class NZWalksDbContext: DbContext
{
    #region Properties

    public DbSet<Region> Regions { get; set; }
    public DbSet<Walk> Walks { get; set; }
    public DbSet<WalkDifficulty> WalkDifficulty { get; set; }

    #endregion
    
    #region ctor

    public NZWalksDbContext(DbContextOptions<NZWalksDbContext> options): base(options)
    {
        
    }

    #endregion
}