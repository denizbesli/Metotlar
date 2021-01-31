using System;

namespace Constructors
{
    //Constructorlar parametre mantığı ile çalışır.
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id = 1, FirstName = "Deniz", LastName = "besli", City = "İstanbul" };
            Customer customer3 = new Customer();
            customer3.Id = 3;

            Customer customer2 = new Customer(2, "Burak", "Besli", "İstanbul");
            Console.WriteLine(customer2.FirstName);
        }
    }

    class Customer
    {
        public Customer()
        {

        }
        public Customer(int id, string firstname, string lastname, string city)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}

