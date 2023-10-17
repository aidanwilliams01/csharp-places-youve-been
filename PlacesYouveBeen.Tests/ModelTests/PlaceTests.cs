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
      Place newPlace = new Place("test");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    // [TestMethod]
    // public void GetMake_ReturnsMake_String()
    // {
    //   string make = "Honda";
    //   Car newCar = new Car(make, "Element");
    //   string result = newCar.Make;
    //   Assert.AreEqual(make, result);
    // }

    // [TestMethod]
    // public void SetMake_SetMake_Void()
    // {
    //   string make = "Honda";
    //   Car newCar = new Car(make, "Element");
    //   string updatedMake = "Honda2";
    //   newCar.Make = updatedMake;
    //   string result = newCar.Make;
    //   Assert.AreEqual(updatedMake, result);
    // }

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
      Place newPlace1 = new Place(place01);
      Place newPlace2 = new Place(place02);
      List<Place> newList = new List<Place> { newPlace1, newPlace2 };
      List<Place> result = Place.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
    {
      string place = "portland";
      Place newPlace = new Place(place);
      int result = newPlace.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectPlace_Place()
    {
      string place01 = "portland";
      string place02 = "vancouver";
      Place newPlace1 = new Place(place01);
      Place newPlace2 = new Place(place02);
      Place result = Place.Find(2);
      Assert.AreEqual(newPlace2, result);
    }
  }
}