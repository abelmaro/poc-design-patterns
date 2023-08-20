using PoC_Observer.Observers.Interfaces;

namespace PoC_Observer.Observers
{
    public class Subscriber : IObserver
    {
        public string Name { get; private set; }

        public Subscriber(string nombre)
        {
            Name = nombre;
        }
        public void Update(string newArticle)
        {
            Console.WriteLine($"Subscriber {Name} has received a notification about the new article: {newArticle}");
        }
    }
}
