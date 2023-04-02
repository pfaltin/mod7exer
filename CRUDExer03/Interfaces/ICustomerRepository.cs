using System;
using CRUDExer03.Models;

namespace CRUDExer03.Interfaces
{
	public interface ICustomerRepository
	{
        public interface ICustomerRepository
        {
            List<Customer> GetCustomers();
            Customer GetCustomerById(int id);
            void AddCustomer(Customer customer);
            void UpdateCustomer(Customer customer);
            void DeleteCustomer(int id);
        }




    }
}

