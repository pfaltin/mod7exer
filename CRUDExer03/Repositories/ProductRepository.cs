using System;
using CRUDExer03.Interfaces;
using CRUDExer03.Models;

namespace CRUDExer03.Repositories
{
	public class ProductRepository : IProductRepository
	{
        private List<Product> _products = new List<Product>();

        public ProductRepository()
		{
            List<Product> products = new List<Product>()
            {
                new Product{ ProductId = 1, Name = "kanta", Description = "plasticna", Price = 11.22M },
                new Product{ ProductId = 1, Name = "boca", Description = "plasticna, 2l", Price = 12.22M },
                new Product{ ProductId = 1, Name = "sokna", Description = "tanka", Price = 2.22M },
                new Product{ ProductId = 1, Name = "guma", Description = "za traktor, 345x37", Price = 122.72M },
                new Product{ ProductId = 1, Name = "zavjesa", Description = "bijela 2x3m", Price = 6.12M },
                new Product{ ProductId = 1, Name = "naocale", Description = "plasticne", Price = 12.23M },
                new Product{ ProductId = 1, Name = "krpa", Description = "mikrofibra, 30x50cm", Price = 0.92M },
                new Product{ ProductId = 1, Name = "hlace", Description = "za vinograd", Price = 22.22M },
                new Product{ ProductId = 1, Name = "majica", Description = "kratki rukav, L velicina", Price = 8.2M },
                new Product{ ProductId = 1, Name = "cipela", Description = "radna, 44", Price = 34.12M },
                new Product{ ProductId = 1, Name = "grablje", Description = "metalne, sa drzaljom", Price = 42.2M }

            };
            _products = products;
		}

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void DeleteProduct(int id)
        {
            _products.Remove(_products.Find(prod => prod.ProductId == id));
        }

        public Product GetProductById(int id)
        {
            Product product = _products.Find(prod => prod.ProductId == id);
            return product;
        }

        public List<Product> GetProducts()
        {
            return _products;
        }

        public void UpdateProduct(Product product)
        {
            _products.Remove(_products.Find(prod => prod.ProductId == product.ProductId));
            _products.Add(product);
        }
    }
}

