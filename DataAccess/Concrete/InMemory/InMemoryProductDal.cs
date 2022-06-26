//using DataAccess.Abstract;
//using Entities.Concrete;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace DataAccess.Concrete.InMemory
//{
//    // gerçek bir ortam varmış gibi simüle etmek için InMemory kullanıyoruz, Entity framework orj iş ve bağlantı
//    public class InMemoryProductDal : ICarDal
//    {
//        List<Car> _products;

//        //CTOR TAB constructor
//        public InMemoryProductDal()
//        {
//            //oracle, sql server, postgres, mangodb
//            _products = new List<ca> {
//                new Product{ ProductId = 1,  CategoryId=1,  ProductName="Bardak", UnitPrice = 15 ,UnitInStock=15,},
//                new Product{ ProductId = 1,  CategoryId=1,  ProductName="Kamera", UnitPrice = 500 ,UnitInStock=3,},
//                new Product{ ProductId = 1,  CategoryId=1,  ProductName="Telefon", UnitPrice = 1500 ,UnitInStock=2,},
//                new Product{ ProductId = 1,  CategoryId=1,  ProductName="Klavye", UnitPrice = 150 ,UnitInStock=65,},
//                new Product{ ProductId = 1,  CategoryId=1,  ProductName="Fare", UnitPrice = 85 ,UnitInStock=1,}
//            };
//        }

//        public void Add(Product product)
//        {
//            _products.Add(product);
//        }

//        public void Delete(Product product)
//        {
//            //Products productToDelete = null;
//            //foreach (var p in _product)
//            //{
//            //    if (product.ProductId == p.ProductId)
//            //    {
//            //        productToDelete = p;
//            //    }   
//            //}

//            //linQ üzerinden gösterim, üsttekide normal yöntemi
//            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
//            // eğer iki sonuç dönerse single işlemde yanlış olur.
//            _products.Remove(productToDelete);
//        }

//        public List<Product> GetAll()
//        {
//            return _products;
//        }

//        public List<Product> GetAllByCategory(int categoryId)
//        {
//            return _products.Where(p => p.CategoryId == categoryId).ToList();
//        }

//        public void Update(Car product)
//        {
//            Car productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ca);
//            productToUpdate.ProductName = product.ProductName;
//            productToUpdate.CategoryId = product.CategoryId;
//            productToUpdate.UnitPrice = product.UnitPrice;
//            productToUpdate.UnitInStock = product.UnitInStock;
//        }
//    }
//}
