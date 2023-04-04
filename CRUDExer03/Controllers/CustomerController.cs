using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDExer03.Interfaces;
using CRUDExer03.Models;
using CRUDExer03.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDExer03.Controllers
{
    public class CustomerController : Controller

    {
        private CustomerRepository _customerRepository;

        // DI (eng.: Dependency Injection) - hrv.: Ubrizgavanje ovisnosti 
        public CustomerController(CustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }


        // GET: Customer
        public ActionResult Index()
        {
            return View(_customerRepository.GetCustomers());
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }




        // POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create( Customer customer)
        //public IActionResult Create([Bind("CustomerId,Name,Email,Phone, Address")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _customerRepository.AddCustomer(customer);
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customer/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}