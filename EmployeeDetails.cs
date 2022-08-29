using System;
using System.Collections.Generic;

namespace Assignment1
{


class StringReturn
{
        static void Main(string[] args)
        {
            CustomerRepo customerRepo = new CustomerRepo();
            Customer customer = new Customer();
            customer.Id = 1;
            customer.Name = "Rani";
            customer.Number = 123;
            List<Customer> customers = customerRepo.Add(customer);
            foreach(Customer c in customers)
            {
                Console.WriteLine($"Id:{c.Id} Name:{c.Name} Number:{c.Number}");
            }
            
        }
       
    }
    class Customer
    {
       public int Id {get;set;}
       public String Name {get;set;}
       public int Number { get; set; }

    }
    class CustomerRepo
    {
        //Add,Remove,Update
        List<Customer> customers = new List<Customer>()
            {
                new Customer()
                {
                    Id = 1,
                    Name = "Raju",
                    Number = 123

                },
                new Customer()
                {
                    Id = 2,
                    Name = "Rani",
                    Number = 124

                },
                new Customer()
                {
                    Id = 3,
                    Name = "Ritu",
                    Number = 125

                }
            };

       public List<Customer> Add(Customer customer)
        {
            customers.Add(customer);
            return customers;
        }
            



    }
}
