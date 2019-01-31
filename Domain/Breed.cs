using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;

namespace Domain
{
    public class Breed : ISubject
    {
        private string breedName;
        private float minWeight;
        private float maxWeight;
        private float averageLifeExpectancy;
        public string BreedName { get { return breedName; } set { breedName = value; NotifyObserver("BreedName"); } }

        public float MinWeight { get { return minWeight; } set { minWeight = value; NotifyObserver("MinWeight"); } }

        public float MaxWeight { get { return maxWeight; } set { maxWeight = value; NotifyObserver("MaxWeight"); } }

        public float AverageLifeExpectancy { get { return averageLifeExpectancy; } set { averageLifeExpectancy = value; NotifyObserver("AverageLifeExpectancy"); } }

        public Breed(string breedName, float minWeight, float maxWeight, float averageLifeExpectancy)
        {
            this.BreedName = breedName;
            this.MinWeight = minWeight;
            this.MaxWeight = maxWeight;
            this.AverageLifeExpectancy = averageLifeExpectancy;
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
