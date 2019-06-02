using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WindowExploreServer.Models;

namespace WindowExploreServer.Infra
{
    public class CustomerRepository:ICustomerRepository
    {
        List<Customer> ICustomerRepository.GetCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer{Id=1,FirstName="Lionel",LastName="Messi"},
                new Customer{Id=2,FirstName="Cristiano",LastName="Ronaldo"}
            };

            return customers;
        }
    }
}