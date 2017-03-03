using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechLab.RouteSort
{
    /// <summary>
    /// Карточка маршрута
    /// </summary>
    class RouteCard
    {
        /// <summary>
        /// Пункт отправления
        /// </summary>
        public string Departure { get; set; }
        /// <summary>
        /// Пункт назначения
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Карточка маршрута принимающая названия городов
        /// </summary>
        /// <param name="departure">Пункт отправления</param>
        /// <param name="destination">Пункт назначения</param>
        public RouteCard(string departure, string destination)
        {
            Departure = departure;
            Destination = destination;
        }

        /// <summary>
        /// Возвращает карточку маршрута в виде string
        /// </summary>
        /// <returns>Строку карточки товара "Пункт отправления → Пункт прибытия"</returns>
        public override string ToString()
        {
            return $"{Departure} → {Destination}";
        }
    }
}
