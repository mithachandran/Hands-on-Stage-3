﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverCaseStudy
{
    public interface INotificationService
    {
        void AddSubscriber(INotificationObserver observer);
        void RemoveSubscriber(INotificationObserver observer);
        void NotifySubscriber();
    }
}
