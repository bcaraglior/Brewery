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
    class recipeTest
    {
        BreweryContext dbContext;
        Recipe r;
        List<Recipe> recipes;

        [SetUp]
        public void SetUp()
        {
            dbContext = new BreweryContext();
        }

        [Test]
        public void testGetRecipeByID()
        {
            r = dbContext.Recipe.Find(2);
            Assert.AreEqual("Krampus' Special Sauce", r.Name);
        }
        
        [Test]
        public void testGetRecipeByName()
        {
            recipes = dbContext.Recipe.Where(r => r.Name.Contains("Fuzzy")).ToList();
            Assert.AreEqual(133, recipes[0].StyleId); 
        }
    }
}
