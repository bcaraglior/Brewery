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
    public class StyleTest
    {
        BreweryContext dbContext;
        Style s;
        List<Style> styles;

        [SetUp]
        public void Setup()
        {
            dbContext = new BreweryContext();
        }
        
        [Test]
        public void testGetStyle()
        {
            s = dbContext.Style.Find(1);
            Assert.AreEqual("Altbier", s.Name);
        }

        [Test]
        public void testGetStylesByName()
        {
            styles = dbContext.Style.Where(s => s.Name.Contains("Ale")).OrderBy(s => s.Name).ToList();
            Assert.AreEqual(styles[0].Name, "American Amber Ale");
        }

        [Test]
        public void testGetStylesByType()
        {
            styles = dbContext.Style.Where(s => s.Type.Contains("Ale")).OrderBy(s => s.Name).ToList();
            Assert.AreEqual(styles[0].Name, "Altbier");
        }
    }
}
