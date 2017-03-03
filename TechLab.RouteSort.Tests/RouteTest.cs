using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TechLab.RouteSort.Tests
{
    [TestClass]
    public class RouteTest
    {
        private List<RouteCard> routeCardList;

        [TestInitialize]
        public void Setup()
        {
            routeCardList = new List<RouteCard>();
            routeCardList.Add(new RouteCard("Москва", "Иркутск"));
            routeCardList.Add(new RouteCard("Брест", "Москва"));
            routeCardList.Add(new RouteCard("Иркутск", "Владивосток"));
        }

        [TestMethod]
        public void Route_Print()
        {
            string s;

            s = Route.Print(routeCardList);

            Assert.AreEqual(s, "Москва → Иркутск, Брест → Москва, Иркутск → Владивосток");
        }

        [TestMethod]
        public void Route_Generation()
        {
            string s;

            s = Route.Print(Route.Generation(routeCardList));

            Assert.AreEqual(s, "Брест → Москва, Москва → Иркутск, Иркутск → Владивосток");
        }
    }
}
