﻿using System.Text;

namespace TestTask
{
    public class Route
    {
        public Route()
        {
            Visits = new Visit[] {};
            RoutePriority = 0;
        }

        public Route(Visit[] visits)
        {
            Visits = visits;
            RoutePriority = visits.Sum(visit => visit.Priority);
        }

        public Route(Visit[] visits, int routePriority)
        {
            Visits = visits;
            RoutePriority = routePriority;
        }

        public int RoutePriority { get; set; }
        public Visit[] Visits { get; set; }

        public static Route Max(Route route1, Route route2)
        {
            return route1.RoutePriority > route2.RoutePriority ? route1 : route2;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            
            foreach(var visit in Visits)
            {
                Console.WriteLine(visit);
            }
            stringBuilder.AppendLine("Время: " + Visits.Sum(visit => visit.VisitTime) / 2.0 + " ч.");
            stringBuilder.AppendLine("Сумма важностей: " + RoutePriority);

            return stringBuilder.ToString();
        }
    }
}