using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloObserver
{
    static class EventAggregator
    {
        // Heizung: Subscribe an alle Nachrichten "Messwert" vom Datentyp "Sensor"
        // -> Liste von allen subscribern, 

        // Subscribe: An was ?, Was soll ausgeführt werden (Callback)
        private static List<Subscriber> subscribers = new List<Subscriber>();

        public static void Subscribe(object subscriberInstance,string message,Action<object> callback)
        {
            subscribers.Add(new Subscriber { SubscriberInstance = subscriberInstance, Message = message, Callback = callback });
        }

        public static void Unsubscribe(object subscriberInstance,string message)
        {
            subscribers.RemoveAll(x => x.SubscriberInstance == subscriberInstance && x.Message == message);
        }

        public static void Publish(string message,object value)
        {
            foreach (var item in subscribers.Where(x => x.Message == message))
            {
                item.Callback?.Invoke(value);
            }
        }
    }

    class Subscriber
    {
        public object SubscriberInstance { get; set; }
        public string Message { get; set; }
        public Action<object> Callback { get; set; }
    }
}
