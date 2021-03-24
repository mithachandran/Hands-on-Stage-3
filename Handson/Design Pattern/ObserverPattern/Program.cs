using System;

namespace ObserverPattern_HandsOn8
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageSubscriberOne s1 = new MessageSubscriberOne();

            MessageSubscriberTwo s2 = new MessageSubscriberTwo();

            MessageSubscriberThree s3 = new MessageSubscriberThree();

            MessagePublisher p = new MessagePublisher();

           
            p.Attach(s1);
            p.Attach(s2);
            p.Attach(s3);

            p.ChangeState(2);

            Console.ReadLine();

        }

    }
}

