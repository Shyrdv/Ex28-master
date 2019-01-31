using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer
{
    public class PetRepo : IObserver, ISubject
    {
        private List<Pet> pets = new List<Pet>();

        public void AddPet(string petName, string petType, string petBreed, string petDOB, string petWeight, int ownerId)
        {
            Pet petObject = new Pet(petName, petType, petBreed, petDOB, petWeight, ownerId);
            pets.Add(petObject);
            NotifyObserver("AddPet");
        }

        public List<Pet> GetAll()
        {
            return pets;
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

        public void Update(ISubject subject, string message)
        {
            NotifyObserver(message);
        }
    }
}
