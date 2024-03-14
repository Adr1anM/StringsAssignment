using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace StringsAssign
{
    class BookTheFlight
    {
        private User User { get; set; }
        private Flight flight { get; set; }
        private DateTimeOffset DepartureTime { get; set; }
        private DateTimeOffset ArrivalTime => DepartureTime + flight.Duration;

        public BookTheFlight(User client,Flight flight, DateTimeOffset departureTime)
        {
            User = client;
            this.flight = flight;
            DepartureTime = departureTime;
        }

        public void ChangeFlightDetails(string newDepartureCity)
        {
            
        }

        public void ShowData()
        {
            decimal currency = 1000.50m;
            Console.WriteLine("Booking Details");
            Console.WriteLine("Departurer Time: {0}", DepartureTime);
            Console.WriteLine("Arrival Time: {0}", ArrivalTime);
            Console.WriteLine("-------------------------------");
            flight.PrintFlightData();
            Console.WriteLine("-------------------------------");
            Console.WriteLine(User.DisplayUserInfo());
            string formatedcurrency = currency.ToString("C", CultureInfo.GetCultureInfo("de-DE"));
            Console.WriteLine("The ticket will cost: {0}",formatedcurrency);
        }

    }
}
