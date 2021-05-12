using System;

namespace EmployeePortal_ObserverDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SubjectProducts companyProduct = new SubjectProducts("Test Product", "Out Of Stock");
            ObserverEmployees user1 = new ObserverEmployees("Vaibhav", companyProduct);
            ObserverEmployees user2 = new ObserverEmployees("VB", companyProduct);
            companyProduct.setAvailability("Available");
        }
    }
}
