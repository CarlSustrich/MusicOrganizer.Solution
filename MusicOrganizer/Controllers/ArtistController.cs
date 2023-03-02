using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System.Collections.Generic;

namespace MusicOrganizer.Controllers
{
  public class ArtistsController : Controller
  {

    [HttpGet("/artists/new")]
    public ActionResult New() 
    {
      return View();
    }

    [HttpPost("/artists")]
    public ActionResult Create(string name, string genre)
    {
      Artist newArtist = new Artist(name, genre);
      return RedirectToAction("Index");
    }

    [HttpGet("/artists")]
    public ActionResult Index()
    {
      List<Artist> artistList = Artist.GetAll();
      return View(artistList);
    }

    [HttpGet("/artists/{artistId}")]
    public ActionResult Show(int artistId)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Artist targetArtist = Artist.Find(artistId);
      List<Record> artistRecords = targetArtist.Albums;
      model.Add("Artist", targetArtist);
      model.Add("Albums", artistRecords);
      return View(model);
    }
  }
}
