using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAssign
{
    public class Flight
    {
        public string DepartureCity { get; set; }
        public string ArrivalCity { get; set; }
        public TimeSpan Duration { get; set; }

        public Flight(string departureCity, string arrivalCity, TimeSpan duration)
        {
            DepartureCity = departureCity;
            ArrivalCity = arrivalCity;
            Duration = duration;
        }

        public void PrintFlightData()
        {
            Console.WriteLine();
            StringBuilder builder = new StringBuilder("Hello", 120);

            builder.Append(" , welcome to Amdaris airline");
            builder.AppendFormat(" , today is {0:MM:dd:yyyy}", DateTime.Now);
            Console.WriteLine(builder);
            Console.WriteLine("Flight Details");
            Console.WriteLine("Departure City: {0}",DepartureCity);
            Console.WriteLine("Arrival city: {0}",ArrivalCity);
            Console.WriteLine("Duration: {0}",Duration);
        }

    }
}
