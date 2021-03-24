using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverCaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            AdminObserver1 admin1 = new AdminObserver1();
            AdminObserver2 admin2 = new AdminObserver2();


            NotificationService service = new NotificationService();
            service.AddSubscriber(admin1);
            service.AddSubscriber(admin2);
            service.NotifySubscriber();
            service.RemoveSubscriber(admin1);
            service.NotifySubscriber();

            Console.ReadLine();
        }
    }
}
