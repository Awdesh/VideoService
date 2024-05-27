using Microsoft.EntityFrameworkCore;

namespace VideoAPI.Models;

public partial class Playlist
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public virtual ICollection<Video> Videos { get; } = new List<Video>();
}
