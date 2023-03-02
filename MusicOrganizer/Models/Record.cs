using System.Collections.Generic;
namespace MusicOrganizer.Models
{
  public class Record
  {
    public string Name { get; set; }
    public static int Indexer { get; set; } =0;
    public int Id {get;}
    private static List<Record> _instances = new List<Record>{};
    // public List<Songs> Songs {get;set;} 

    public Record(string name, int artistId)
    {
      Name = name;
      Id = Indexer;
      Record.Indexer ++;
      _instances.Add(this);
      Artist targetArtist = Artist.Find(artistId);
      targetArtist.AddAlbum(this);
    }



  }
}
