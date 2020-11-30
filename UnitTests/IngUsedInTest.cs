using NUnit.Framework;
using BrewEFCore.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
    [TestFixture]
    class IngUsedInTest
    {
        BreweryContext dbContext;
        IngredientUsedIn i;
        List<IngredientUsedIn> ingredients;
        
        [SetUp]
        public void SetUp()
        {
            dbContext = new BreweryContext();
        }

        [Test]
        public void testGetIngByID()
        {
            i = dbContext.IngredientUsedIn.Find(278, 1);
            Assert.AreEqual(278, i.IngredientId);
            Assert.AreEqual(1, i.StyleId);
        }

        [Test]
        public void testGetIngListByStyleID()
        {
            ingredients = dbContext.IngredientUsedIn.Where(i => i.StyleId.Equals(1)).OrderBy(i => i.IngredientId).ToList();
            Assert.AreEqual(400, ingredients[5].IngredientId);
        }
    }
}
