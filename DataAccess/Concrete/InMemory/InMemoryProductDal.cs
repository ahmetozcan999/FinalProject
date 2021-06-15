using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> { 
            new Product{CategoryId=1,ProductId=1,ProductName="ürün1",UnitPrice=25,UnitsInStock=3 },
            new Product{CategoryId=2,ProductId=2,ProductName="ürün2",UnitPrice=30,UnitsInStock=4 },
            new Product{CategoryId=3,ProductId=3,ProductName="ürün3",UnitPrice=35,UnitsInStock=5 },
            new Product{CategoryId=4,ProductId=4,ProductName="ürün4",UnitPrice=40,UnitsInStock=6 },
            new Product{CategoryId=5,ProductId=5,ProductName="ürün5",UnitPrice=45,UnitsInStock=7 },
            new Product{CategoryId=6,ProductId=6,ProductName="ürün6",UnitPrice=50,UnitsInStock=8 }
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
           Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
