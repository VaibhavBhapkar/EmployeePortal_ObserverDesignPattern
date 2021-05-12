using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePortal_ObserverDesignPattern
{
    public class ObserverEmployees:IObserverEmployees
    {
        public string UserName { get; set; }
        public ObserverEmployees(string userName, ISubjectProducts subject)
        {
            UserName = userName;
            subject.AddObserver(this);
        }

        public void Update(string availabiliy)
        {
            Console.WriteLine("Hello " + UserName + ", Product is now " + availabiliy + " on Company Portal");
        }
    }
}
