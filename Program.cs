using VideoAPI.Models;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<VideoContext>();

var provider = builder.Services.BuildServiceProvider();
var _configuration = provider.GetRequiredService<IConfiguration>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


using VideoContext context = new VideoContext(_configuration);

Playlist playlist = new Playlist()
{
    Title = "Active Wear - Men",
    Description = "Sample Description"
};

context.Playlists.Add(playlist);
context.SaveChanges();

Video video = new Video()
{
    Title = "Grunge Skater Jeans",
    Description = "AWMGSJ",
    IsPublic = true,
    PlaylistId = playlist.Id
};

context.Videos.Add(video);
context.SaveChanges();


