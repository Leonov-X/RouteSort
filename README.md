# RouteSort
Сортировка маршрута

Создается лист карточек маршрутов:
'''
List<RouteCard> routeCardList = new List<RouteCard>();
routeCardList.Add(new RouteCard("Москва", "Иркутск"));
routeCardList.Add(new RouteCard("Брест", "Москва"));
routeCardList.Add(new RouteCard("Иркутск", "Владивосток"));
'''

Сортируем маршрутные карточки:
'''
routeCardList = Route.Generation(routeCardList);
'''