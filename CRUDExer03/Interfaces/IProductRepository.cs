using System;
using CRUDExer03.Models;

namespace CRUDExer03.Interfaces
{
	public interface IProductRepository
	{

        List<Product> GetProducts();
        Product GetProductById(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);



    }
}

