using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechLab.RouteSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<RouteCard> routeCardList = new List<RouteCard>();
            routeCardList.Add(new RouteCard("Москва", "Иркутск"));
            routeCardList.Add(new RouteCard("Брест", "Москва"));
            routeCardList.Add(new RouteCard("Иркутск", "Владивосток"));

            Console.WriteLine($"Маршрутные карточки: {Route.Print(routeCardList)}");
            routeCardList = Route.Generation(routeCardList);
            Console.WriteLine($"Маршрут построенный: {Route.Print(routeCardList)}");

            Console.WriteLine();

            // Консоль ожидает нажатия клавиши
            Console.ReadKey();
        }
    }
}
