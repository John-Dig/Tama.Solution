using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tama.Models;
using System;

namespace Tama.Tests
{
  [TestClass]
  public class PetTests
  {

    [TestMethod] //1
    public void PetConstructor_CreatesInstanceOfPet_Pet()
    {
      Pet newPet = new Pet(50, 50, 50);
      Assert.AreEqual(typeof(Pet), newPet.GetType());
    }

    [TestMethod] //2
    public void PetPlay_Adds10ContentmentToMuffin_Int()
    {
      //arrange 
      int content = 50;
      int rested = 50;
      int fed = 50;
      
      //act
      Pet newPet = new Pet(content,rested,fed);
      newPet.Play();
      
      //assert
      Assert.AreEqual(60, newPet.Content);
    }

    [TestMethod] //3
    public void PetFeed_Adds10FedToMuffin_Int()
    {
      //arrange 
      int content = 50;
      int rested = 50;
      int fed = 50;
      
      //act
      Pet newPet = new Pet(content,rested,fed);
      newPet.Feed();
      
      //assert
      Assert.AreEqual(60, newPet.Fed);
    }



  }
}