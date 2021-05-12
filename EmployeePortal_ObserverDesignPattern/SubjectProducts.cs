using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePortal_ObserverDesignPattern
{
    public class SubjectProducts: ISubjectProducts
    {
        private List<IObserverEmployees> observers = new List<IObserverEmployees>();
        private string ProductName { get; set; }
        private string Availability { get; set; }
        public SubjectProducts(string productName,string availability)
        {
            ProductName = productName;
            Availability = availability;
        }
        public void AddObserver(IObserverEmployees observer)
        {
            this.observers.Add(observer);
        }
        public string getAvailability()
        {
            return Availability;
        }
        public void setAvailability(string availability)
        {
            this.Availability = availability;
            Console.WriteLine("Availability changed from Out of Stock to Available.");
            NotifyObservers();
        }
        public void NotifyObservers()
        {
            Console.WriteLine("Product Name :"
                + ProductName + "is Now available. So notifying all Registered users ");
            Console.WriteLine();
            foreach (IObserverEmployees observer in observers)
            {
                observer.Update(Availability);
            }
        }

        public void RemoveObserver(IObserverEmployees observer)
        {
            this.observers.Remove(observer);
        }
    }
}
