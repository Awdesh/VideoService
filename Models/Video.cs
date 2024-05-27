using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace VideoAPI.Models;

public partial class Video
{
    public int Id { get; set; }

    public string Title { get; set; } = "Sample Video";

    public string Description { get; set; }

    public bool IsPublic { get; set; }

    public int PlaylistId { get; set; }

    public Playlist playlist { get; set; } = null!;
}
