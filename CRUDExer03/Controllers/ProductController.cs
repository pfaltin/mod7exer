using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDExer03.Interfaces;
using CRUDExer03.Models;
using CRUDExer03.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CRUDExer03.Controllers
{

        //Index()

        //Create()

        //Edit(int id)

        //Edit(int id, Product product)

        //Delete(int id)

        //DeleteConfirmed(int id)

        public class ProductController : Controller
        {
            private readonly ProductRepository _productRepository;

            public ProductController(ProductRepository productRepository)
            {
                _productRepository = productRepository;
            }

            // GET: Product
            public IActionResult Index()
            {
                var products = _productRepository.GetProducts();
                return View(products);
            }

            // GET: Product/Create
            public IActionResult Create()
            {
                return View();
            }




            // POST: Product/Create
            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Create([Bind("Id,Name,Description,Price")] Product product)
            {
                if (ModelState.IsValid)
                {
                    _productRepository.AddProduct(product);
                    return RedirectToAction(nameof(Index));
                }
                return View(product);
            }

            // GET: Product/Edit/5
            public IActionResult Edit(int id)
            {
                var product = _productRepository.GetProductById(id);
                if (product == null)
                {
                    return NotFound();
                }
                return View(product);
            }

            // POST: Product/Edit/5
            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Edit(int id, [Bind("Id,Name,Description,Price")] Product product)
            {
                if (id != product.ProductId)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    _productRepository.UpdateProduct(product);
                    return RedirectToAction(nameof(Index));
                }
                return View(product);
            }

            // GET: Product/Delete/5
            public IActionResult Delete(int id)
            {
                var product = _productRepository.GetProductById(id);
                if (product == null)
                {
                    return NotFound();
                }
                return View(product);
            }

            // POST: Product/Delete/5
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public IActionResult DeleteConfirmed(int id)
            {
                _productRepository.DeleteProduct(id);
                return RedirectToAction(nameof(Index));
            }
        }







}