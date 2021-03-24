using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverCaseStudy
{
    public interface INotificationObserver
    {
        string Name { get; }

        void TicketsBooked();
    }
}