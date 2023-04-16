using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer {Id=1, FirstName = "Utku", Lastname = "Cevik",City = "Mersin" }; // when you call the class as new its gonna call constructor class as default
            Customer customer2 = new Customer(2,"Ali","Berge","İstanbul");
            Console.WriteLine(customer2.FirstName);

        }
    }
    class Customer
    {
        // even if you dont create a constructor it create a constructor as default.
        public Customer()
        {

        }
        public Customer(int id, string firstname, string lastname, string city) // for both class to work we should overload** the class like method.
        { 
            Id = id;
            FirstName = firstname;
            Lastname = lastname; 
            City = city;

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string City { get; set; }

    }
}
