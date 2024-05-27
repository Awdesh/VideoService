using Microsoft.EntityFrameworkCore;

namespace VideoAPI.Models;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Playlist>().HasData(
            new Playlist { Id = 1, Title = "Active Wear - Men", Description = "Sample playlist-1" },
            new Playlist { Id = 2, Title = "Active Wear - Men", Description = "Sample playlist-2" },
            new Playlist { Id = 3, Title = "Active Wear - Men", Description = "Sample playlist-3" });

        modelBuilder.Entity<Video>().HasData(
            new Video { Id = 1, PlaylistId = 1, Title = "Grunge Skater Jeans", Description = "AWMGSJ", IsPublic = true },
            new Video { Id = 2, PlaylistId = 1, Title = "Polo Shirt", Description = "AWMPS", IsPublic = true },
            new Video { Id = 3, PlaylistId = 1, Title = "Skater Graphic T-Shirt", Description = "AWMSGT", IsPublic = true },
            new Video { Id = 4, PlaylistId = 1, Title = "Slicker Jacket", Description = "AWMSJ", IsPublic = true },
            new Video { Id = 5, PlaylistId = 1, Title = "Thermal Fleece Jacket", Description = "AWMTFJ", IsPublic = true },
            new Video { Id = 6, PlaylistId = 1, Title = "Unisex Thermal Vest", Description = "AWMUTV", IsPublic = true },
            new Video { Id = 7, PlaylistId = 1, Title = "V-Neck Pullover", Description = "AWMVNP", IsPublic = true },
            new Video { Id = 8, PlaylistId = 1, Title = "V-Neck Sweater", Description = "AWMVNS", IsPublic = true },
            new Video { Id = 9, PlaylistId = 1, Title = "V-Neck T-Shirt", Description = "AWMVNT", IsPublic = true },
            new Video { Id = 10, PlaylistId = 2, Title = "Bamboo Thermal Ski Coat", Description = "AWWBTSC", IsPublic = true },
            new Video { Id = 11, PlaylistId = 2, Title = "Cross-Back Training Tank", Description = "AWWCTT", IsPublic = false },
            new Video { Id = 12, PlaylistId = 2, Title = "Grunge Skater Jeans", Description = "AWWGSJ", IsPublic = true },
            new Video { Id = 13, PlaylistId = 2, Title = "Slicker Jacket", Description = "AWWSJ", IsPublic = true },
            new Video { Id = 14, PlaylistId = 2, Title = "Stretchy Dance Pants", Description = "AWWSDP", IsPublic = true },
            new Video { Id = 15, PlaylistId = 2, Title = "Ultra-Soft Tank Top", Description = "AWWUTT", IsPublic = true },
            new Video { Id = 16, PlaylistId = 2, Title = "Unisex Thermal Vest", Description = "AWWUTV", IsPublic = true },
            new Video { Id = 17, PlaylistId = 2, Title = "V-Next T-Shirt", Description = "AWWVNT", IsPublic = true },
            new Video { Id = 18, PlaylistId = 3, Title = "Blueberry Mineral Water", Description = "MWB", IsPublic = true },
            new Video { Id = 19, PlaylistId = 3, Title = "Lemon-Lime Mineral Water", Description = "MWLL", IsPublic = true },
            new Video { Id = 20, PlaylistId = 3, Title = "Orange Mineral Water", Description = "MWO", IsPublic = true },
            new Video { Id = 21, PlaylistId = 3, Title = "Peach Mineral Water", Description = "MWP", IsPublic = true },
            new Video { Id = 22, PlaylistId = 3, Title = "Raspberry Mineral Water", Description = "MWR", IsPublic = true },
            new Video { Id = 23, PlaylistId = 3, Title = "Strawberry Mineral Water", Description = "MWS", IsPublic = true },
            new Video { Id = 24, PlaylistId = 4, Title = "In the Kitchen with H+ Sport", Description = "PITK", IsPublic = true });
    }
}

