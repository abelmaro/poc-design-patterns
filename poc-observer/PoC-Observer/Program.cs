using PoC_Observer.Observers;
using PoC_Observer.Subjets;

namespace PoC_Observer
{
    public class Program
    {
        protected Program() { }
        public static void Main()
        {

            Post publisher = new();
            Subscriber subscriber1 = new("Pedro");
            Subscriber subscriber2 = new("Juan");
            Subscriber subscriber3 = new("Carlos");

            publisher.Subscribe(subscriber1);
            publisher.Subscribe(subscriber2);
            publisher.Subscribe(subscriber3);

            publisher.PublicarArticulo("New trends in software development");

            publisher.CancelSubscription(subscriber1);
            publisher.CancelSubscription(subscriber2);

            publisher.PublicarArticulo("Introduction to AI");

            publisher.PublicarArticulo("The Future of Technology: Exploring Emerging Trends");
        }
    } 
}