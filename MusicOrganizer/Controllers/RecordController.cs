using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System.Collections.Generic;

namespace MusicOrganizer.Controllers
{
  public class RecordsController : Controller
  {
    
    [HttpGet("/artist/{artistId}/album/new")]
    public ActionResult New(int artistId)
    {
      Artist targetArtist = Artist.Find(artistId);
      return View(targetArtist);
    }

    [HttpPost("/artist/{pathwayArtistId}/record")]
    public ActionResult Create(int pathwayArtistId, string albumName)
    {
      Artist targetArtist = Artist.Find(pathwayArtistId);
      Record newRecord = new Record(albumName, pathwayArtistId);
      // string redirectUrl = $"/artists/{pathwayArtistId}";
      return Redirect($"/artists/{pathwayArtistId}");
    }

  }
}