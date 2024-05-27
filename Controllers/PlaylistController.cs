using Microsoft.AspNetCore.Mvc;
using VideoAPI.Models;
using System.Threading;

namespace VideoAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PlaylistsController : ControllerBase
{
    private readonly VideoContext _videoContext;

    public PlaylistsController(VideoContext videoContext)
    {
        this._videoContext = videoContext;
    }

    [HttpGet]
    public IEnumerable<Playlist> GetAllPlaylists()
    {
        return _videoContext.Playlists.ToList();
    }

    [HttpGet("{id}")]
    public IActionResult GetVideo(int id)
    {
        var playlist = _videoContext.Playlists.FirstOrDefault(v => v.Id == id);
        if (playlist == null)
        {
            return NotFound();
        }
        return Ok(playlist);
    }

    [HttpPost]
    public void Post(Playlist playlist)
    {
        var pl = new Playlist { Title = playlist.Title, Description = playlist.Description };
        _videoContext.Playlists.Add(pl);
        _videoContext.SaveChanges();
    }
}