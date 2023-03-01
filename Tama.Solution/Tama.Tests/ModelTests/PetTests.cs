using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tama.Models;
using System;

namespace Tama.Tests
{
  [TestClass]
  public class PetTests
  {

    [TestMethod]
    public void PetConstructor_CreatesInstanceOfPet_Pet()
    {
      Pet newPet = new Pet(100, 100, 100);
      Assert.AreEqual(typeof(Pet), newPet.GetType());
    }


  }
}