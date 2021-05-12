using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePortal_ObserverDesignPattern
{
    public interface ISubjectProducts
    {
        void AddObserver(IObserverEmployees observer);
        void RemoveObserver(IObserverEmployees observer);
        void NotifyObservers();
    }
}
