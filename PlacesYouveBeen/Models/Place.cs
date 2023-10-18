using System.Collections.Generic;

namespace PlacesYouveBeen.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public string StayLength { get; set; }
    public string JournalEntry { get; set; }
    public string ImageURL { get; set; }
    public int Id { get; }
    private static List<Place> _instances = new List<Place> { };

    public Place(string cityName, string stayLength, string journalEntry, string imageURL )
    {
      CityName = cityName;
      StayLength = stayLength;
      JournalEntry = journalEntry;
      ImageURL = imageURL;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Place> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Place Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}