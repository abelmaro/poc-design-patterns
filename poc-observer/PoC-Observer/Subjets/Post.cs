using PoC_Observer.Observers.Interfaces;

namespace PoC_Observer.Subjets
{
    public class Post
    {
        private readonly List<IObserver> suscribers = new();
        private string? lastPost;
        public void Subscribe(IObserver suscriptor)
        {
            suscribers.Add(suscriptor);
        }

        public void CancelSubscription(IObserver suscriptor)
        {
            suscribers.Remove(suscriptor);
        }

        public void NotifySuscribers()
        {
            foreach (var suscriptor in suscribers)
            {
                if (lastPost != null) suscriptor.Update(lastPost);
            }
        }

        public void PublicarArticulo(string nuevoArticulo)
        {
            lastPost = nuevoArticulo;
            NotifySuscribers();
        }
    }
}
