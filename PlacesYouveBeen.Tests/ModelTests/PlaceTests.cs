using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlacesYouveBeen.Models;
using System;
using System.Collections.Generic;

namespace PlacesYouveBeen.Tests
{
  [TestClass]
  public class PlaceTests : IDisposable
  {

    public void Dispose()
    {
      Place.ClearAll();
    }

    [TestMethod]
    public void PlaceConstructor_CreatesInstanceOfPlace_Place()
    {
      Place newPlace = new Place("test", "test", "test", "test");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_PlaceList()
    {
      List<Place> newList = new List<Place> { };
      List<Place> result = Place.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsPlaces_PlaceList()
    {
      string place01 = "portland";
      string place02 = "vancouver";
      Place newPlace1 = new Place(place01, "test", "test", "test");
      Place newPlace2 = new Place(place02, "test", "test", "test");
      List<Place> newList = new List<Place> { newPlace1, newPlace2 };
      List<Place> result = Place.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
    {
      string place = "portland";
      Place newPlace = new Place(place, "test", "test", "test");
      int result = newPlace.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectPlace_Place()
    {
      string place01 = "portland";
      string place02 = "vancouver";
      Place newPlace1 = new Place(place01, "test", "test", "test");
      Place newPlace2 = new Place(place02, "test", "test", "test");
      Place result = Place.Find(2);
      Assert.AreEqual(newPlace2, result);
    }
  }
}