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
    public List<Record> Albums {get;set;}


    public Artist(string name, string genre) {
      Name = name;
      Genre = genre;
      Id = Indexer;
      Artist.Indexer ++;
      _instances.Add(this);
      Albums = new List<Record>{};
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

    // public static void Delete(int artistId)
    // {
    //   foreach(Artist item in _instances)
    //   {
    //     if(artistId == item.Id)
    //     {
    //       _instances.Remove(item);
    //     }
    //   }
    // }



  }
}
