using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;

namespace ApplicationLayer
{
    public class Owner : ISubject
    {
        private string ownerFirstName;
        private string ownerLastName;
        private string ownerPhone;
        private string ownerEmail;
        private int ownerId;
        public string OwnerFirstName { get { return ownerFirstName; } set { ownerFirstName = value; NotifyObserver("OwnerFirstName"); } }

        public string OwnerLastName { get { return ownerLastName; } set { ownerLastName = value; NotifyObserver("OwnerLastName"); } }

        public string OwnerPhone { get { return ownerPhone; } set { ownerPhone = value; NotifyObserver("OwnerPhone"); } }

        public string OwnerEmail { get { return ownerEmail; } set { ownerEmail = value; NotifyObserver("OwnerEmail"); } }

        public int OwnerId { get { return ownerId; } set { ownerId = value; NotifyObserver("OwnerId"); } }

        public Owner(string ownerFirstName, string ownerLastName, string ownerPhone, string ownerEmail, int ownerId)
        {
            this.OwnerFirstName = ownerFirstName;
            this.OwnerLastName = ownerLastName;
            this.OwnerPhone = ownerPhone;
            this.OwnerEmail = ownerEmail;
            this.OwnerId = ownerId;

        }

        List<IObserver> observers = new List<IObserver>();

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObserver(string message)
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(this, message);
            }
        }
    }
}
