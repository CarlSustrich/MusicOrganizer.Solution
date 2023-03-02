using System;
using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Artist
  {
    public string Name {get;set;}
    public string Genre {get;set;}
    public int Indexer {get;set;} = 0;
    public int Id {get;}
    private static List<Artist> _instances = new List<Artist>{};
    // public List<Album> Albums {get;set;}


    public Artist(string name, string genre) {
      Name = name;
      Genre = genre;
      Id = Indexer;
      Indexer ++;
      _instances.Add(this);
    }

    public static List<Artist> GetAll()
    {
      return _instances;
    }
  }
}
