using RestaurantAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerWebAPI.services
{
    public class CustomerService : ICustomerService
    {
        
            public static readonly List<Customer> customers = new List<Customer>()
            {
               new Customer {CustomerID =1,CustomerName="Sammy"},
               new Customer {CustomerID =2,CustomerName="Jake"},

            };




            public async Task<IEnumerable<Customer>> GetCustomers()
            {
                await Task.Delay(1000);
                return customers;
            }



           /* public async Task<Customer> GetCustomerById(int CustomerID)
            {
                var result = customers.SingleOrDefault(a => a.CustomerID == CustomerID);
                return result;
            }



            public async Task<Customer> CreateCustomer(Customer CustomerObj)
            {
                customers.Add(CustomerObj);
                return CustomerObj;
            }*/



            
}
}
