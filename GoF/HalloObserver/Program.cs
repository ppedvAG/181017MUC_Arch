using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            Sensor aussensensor = new Sensor();
            Heizung wohnzimmerheizung = new Heizung();

            EventAggregator.Subscribe(wohnzimmerheizung, "Messwert", wohnzimmerheizung.MesswertVerarbeiten);

            aussensensor.MesswertSchicken();
            aussensensor.MesswertSchicken();
            EventAggregator.Unsubscribe(wohnzimmerheizung, "Messwert");

            aussensensor.MesswertSchicken();

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }

    class Heizung
    {
        public void MesswertVerarbeiten(object wert)
        {
            // object -> immer ein int
            int temp = (int)wert;
            if(temp < 10)
                Console.WriteLine($"Heizung wird aufgedreht: Temp {temp}");
            else if(temp >35)
                Console.WriteLine($"Klimaanlage wird aufgedreht: Temp {temp}");
            else
                Console.WriteLine($"Gemütlich warm : Temp {temp}");
        }
    }

    class Sensor
    {
        public void MesswertSchicken()
        {
            EventAggregator.Publish("Messwert", new Random().Next(0, 100));
        }
    }
}
