using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechLab.RouteSort
{
    /// <summary>
    /// Работа с маршрутами
    /// </summary>
    static class Route
    {
        // Берем первую карточку и выстраиваем все последующие карточки, когда следующих карточек больше не осталось
        // собираем карточки предыдущие первой в собраном маршруте.
        // Если были использованы все карточки возвращаем полученый маршрут.

        /// <summary>
        /// Генерация маршрута
        /// </summary>
        /// <param name="routeCardList">Список карточек маршрута</param>
        /// <returns>Упорядоченый маршрут</returns>
        public static List<RouteCard> Generation(List<RouteCard> routeCardList)
        {
            if (routeCardList != null && routeCardList.Count != 0)
            {
                List<RouteCard> route = new List<RouteCard>();

                route.Add(routeCardList.First());
                routeCardList.RemoveAt(0);

                RouteCard temp;

                // Строим маршрут в право
                while (routeCardList.Count != 0)
                {
                    temp = routeCardList.FirstOrDefault(x => x.Departure == route.Last().Destination);
                    if (temp != null)
                    {
                        route.Add(temp);
                        routeCardList.Remove(temp);
                    }
                    else
                        break;
                }

                // Строим маршрут в лево
                while (routeCardList.Count != 0)
                {
                    temp = routeCardList.FirstOrDefault(x => x.Destination == route.First().Departure);
                    if (temp != null)
                    {
                        route.Insert(0, temp);
                        routeCardList.Remove(temp);
                    }
                    else
                        break;
                }

                if (routeCardList.Count == 0)
                {
                    return route;
                }
            }

            // Возвращаем Null если маршрут не удалось полностью построить
            return null;
        }

        /// <summary>
        /// Формирует строку всего пути
        /// </summary>
        /// <param name="routeCardList">Список карточек маршрута</param>
        /// <returns>Строка маршрута</returns>
        public static string Print(List<RouteCard> routeCardList)
        {
            if (routeCardList != null && routeCardList.Count != 0)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var routeCard in routeCardList)
                {
                    sb.Append($"{routeCard}, ");
                }
                sb.Remove(sb.Length - 2, 2);
                return sb.ToString();
            }

            return string.Empty;
        }
    }
}
