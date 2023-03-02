using System;
using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Artist
  {
    public string Name {get;set;}
    public string Genre {get;set;}
    public static int Indexer {get;set;} = 0;
    public int Id {get;}
    private static List<Artist> _instances = new List<Artist>{};
    private List<Record> _albums;


    public Artist(string name, string genre) {
      Name = name;
      Genre = genre;
      Id = Indexer;
      Artist.Indexer ++;
      _instances.Add(this);
    }

    public void AddAlbum(Record item)
    {
      _albums.Add(item);
    }

    public List<Record> GetAlbums()
    {
      return _albums;
    }

    public static List<Artist> GetAll()
    {
      return _instances;
    }

    public static Artist Find(int artistId)
    {
      foreach(Artist item in _instances)
      {
        if(artistId == item.Id)
        {
          return item;
        }
      }
      return new Artist("artist not found", "no genre");
    }



  }
}
