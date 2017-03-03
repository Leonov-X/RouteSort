using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TechLab.RouteSort.Tests
{
    [TestClass]
    public class RouteCardTest
    {
        [TestMethod]
        public void RouteCard_ToString()
        {
            RouteCard routeCard;
            string s;

            routeCard = new RouteCard("Москва", "Минеральные воды");
            s = routeCard.ToString();

            Assert.AreEqual(s, "Москва → Минеральные воды");
        }
    }
}
