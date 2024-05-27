using Microsoft.AspNetCore.Mvc;
using VideoAPI.Models;
using System.Threading;

namespace VideoAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class VideosController : ControllerBase
{
    private readonly VideoContext _videoContext;

    public VideosController(VideoContext videoContext)
    {
        this._videoContext = videoContext;
        _videoContext.Database.EnsureCreated();
    }

    [HttpGet]
    public IEnumerable<Video> GetAllVideos()
    {
        return _videoContext.Videos.Where(v => v.IsPublic == true);
    }

    [HttpGet("{id}")]
    public IActionResult GetVideo(int id)
    {
        var video = _videoContext.Videos.FirstOrDefault(v => v.Id == id);
        if (video == null)
        {
            return NotFound();
        }
        return Ok(video);
    }


    [HttpPost]
    public void Post(Video video)
    {
        ICollection<Video> videos = new List<Video>();

        for (int i = 0; i < 10; i++)
        {
            bool flag = false;
            if (i % 2 == 0)
            {
                flag = true;
            }
            var v = new Video { Title = video.Title, Description = video.Description, IsPublic = flag };
            _videoContext.Videos.Add(v);
        }

        _videoContext.SaveChanges();

    }

    [HttpPut("{id}")]
    public IActionResult UpdateVideo(Video video, int id)
    {
        if (id != video.Id)
        {
            return BadRequest();
        }

        var existingVideo = _videoContext.Videos.Where(x => x.Id == id).FirstOrDefault();
        if (existingVideo != null)
        {
            existingVideo.Title = video.Title;
            existingVideo.Description = video.Description;
            existingVideo.IsPublic = video.IsPublic;
            _videoContext.SaveChanges();
        }
        else
        {
            return NotFound();
        }
        return Ok(existingVideo);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteVideo(int id)
    {
        var existingVideo = _videoContext.Videos.Where(x => x.Id == id).FirstOrDefault();
        if (existingVideo != null)
        {
            _videoContext.Videos.Remove(existingVideo);
            _videoContext.SaveChanges();
        }
        else
        {
            return NotFound();
        }
        return Ok();
    }
}