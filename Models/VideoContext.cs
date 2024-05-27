using Microsoft.EntityFrameworkCore;

namespace VideoAPI.Models;

public class VideoContext : DbContext
{
    public VideoContext() { }

    protected readonly IConfiguration Configuration;

    public VideoContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // connect to postgres with connection string from app settings
        optionsBuilder.UseNpgsql(Configuration.GetConnectionString("VideoDB"));
    }

    public VideoContext(DbContextOptions<VideoContext> options) : base(options) { }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<Playlist>()
    //         .HasMany(c => c.Videos)
    //         .WithOne(a => a.playlist)
    //         .HasForeignKey(a => a.PlaylistId)
    //         .IsRequired();

    //     modelBuilder.Seed();
    // }

    public DbSet<Video> Videos { get; set; }

    public DbSet<Playlist> Playlists { get; set; }
}