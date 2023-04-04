using System;
using System.Collections.Generic;
using CRUDExer03.Interfaces;
using CRUDExer03.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace CRUDExer03.Repositories
{
	public class CustomerRepository: ICustomerRepository
	{
        private static List<Customer> _customers;
        public CustomerRepository()
        {
            if (_customers == null)
            {
                _customers = new List<Customer>();
                SImData();

            }
            
        }

        public IEnumerable<Customer> GetCustomers()
        { 

            return _customers;
        }
        public Customer GetCustomerById(int id)
        {
            Customer customer = _customers.Find(cust => cust.CustomerId == id);
            return customer;
        }

        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
        }

        public void UpdateCustomer(Customer customer)
        {   
            _customers.Remove(_customers.Find(cust => cust.CustomerId == customer.CustomerId));
            _customers.Add(customer);
        }
        public void DeleteCustomer(int id)
        {
            _customers.Remove(_customers.Find(cust => cust.CustomerId == id));
        }

        public void SImData()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer {CustomerId = 1,Name = "Kupac Prvi", Address="Prva 1, Prvic", Email="", Phone= "" },
                new Customer {CustomerId = 2,Name = "Kupac Drugi", Address="Druga 2, Drugic", Email="", Phone= "" },
                new Customer {CustomerId = 3,Name = "Kupac Treci", Address="Treca 3, Trecic", Email="", Phone= "" },
                new Customer {CustomerId = 4,Name = "Kupac Cetvrti", Address="Cetvrta 4, Cetvrtani", Email="", Phone= "" },
                new Customer {CustomerId = 5,Name = "Kupac Peti", Address="Peta 5, Petani", Email="", Phone= "" },
                new Customer {CustomerId = 6,Name = "Kupac Sesti", Address="Sesta 6, Sestani", Email="", Phone= "" },
            };
            _customers = customers;
        }

    }
}

