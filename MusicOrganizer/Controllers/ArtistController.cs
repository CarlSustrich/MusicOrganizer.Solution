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
      Artist targetArtist = Artist.Find(artistId);
      return View(targetArtist);
    }
  }
}
