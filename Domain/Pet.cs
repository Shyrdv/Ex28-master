using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;

namespace ApplicationLayer
{
    public class Pet : ISubject
    {
        private string petName;
        private string petType;
        private string petBreed;
        private string petDOB;
        private string petWeight;
        private int ownerId;
        public string PetName { get { return petName; } set { petName = value; NotifyObserver("PetName"); } }

        public string PetType { get { return petType; } set { petType = value; NotifyObserver("PetType"); } }

        public string PetBreed { get { return petBreed; } set { petBreed = value; NotifyObserver("PetBreed"); } }

        public string PetDOB { get { return petDOB; } set { petDOB = value; NotifyObserver("PetDOB"); } }

        public string PetWeight { get { return petWeight; } set { petWeight = value; NotifyObserver("PetWeight"); } }

        public int OwnerId { get { return ownerId; } set { ownerId = value; NotifyObserver("OwnerId"); } }

        public Pet(string petName, string petType, string petBreed, string petDOB, string petWeight, int ownerId)
        {
            this.PetName = petName;
            this.PetType = petType;
            this.PetBreed = petBreed;
            this.PetDOB = petDOB;
            this.PetWeight = petWeight;
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

        public override string ToString()
        {
            return petName + petType + petBreed + petDOB + petWeight + ownerId;
        }
    }
}
