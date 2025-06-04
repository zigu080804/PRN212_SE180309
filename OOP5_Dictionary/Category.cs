using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP5_Dictionary
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<int,Product> Products { get; set;}
        public Category()
        {
            Products = new Dictionary<int,Product>();
        }
        /* 
         * Mọi dữ liệu cần làm đủ
         */
        public void AddProduct(Product product)
        {
            if (Products.ContainsKey(product.Id))
            {
                return; // id already exist
            }
            Products.Add(product.Id, product);
        }
        public void PrintAllProducts()
        {
            foreach (KeyValuePair<int, Product> item in Products)
            {
                Product p = item.Value; // item.key is primary key
                Console.WriteLine(p);
            }
        }
        public Dictionary<int, Product> FlterProductByPrice(double min, double max)
        {
            Dictionary<int, Product> result = new Dictionary<int, Product>();
            result = Products.Where(item => item.Value.Price >= min && item.Value.Price <= max)
                .ToDictionary<int, Product>();
            return result;
        }
        public Dictionary<int,Product> FilterIncreasingByPrice()
        {
            return Products.OrderBy(item => item.Value.Price)
                .ToDictionary<int, Product>();
        }

        public Dictionary<int,Product> FilterIncreasingByPriceByQuantity()
        {
            return Products.OrderByDescending(item => item.Value.Quantity)
                           .OrderBy(item => item.Value.Price)
                           .ToDictionary<int,Product>();
        }
        public bool UpdateProduct(Product product)
        {
            if(Products.ContainsKey(product.Id))
            {
                return false;
            }
            Products[product.Id] = product;// đè dữ liệu lên ô nhớ hiện tại 
                                           // hoặc tham chiếu tới ô nhớ khác 
            return true;
        }
        public bool RemoveProduct(int id)
        {
            if(Products.ContainsKey(id)  == false ) return false;

            return Products.Remove(id);

        }
    }
}
