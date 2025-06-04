using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLinQtoObject2
{
    public class ListProduct
    {
        List<Product> products; 
        public ListProduct()
        {
            products = new List<Product>();
        }
        public void gen_products()
        {
            products.Add(new Product() { Id = 1, Name = "Tý" , Quantity = 11, Price = 21});
            products.Add(new Product() { Id = 2, Name = "Hợi", Quantity = 12, Price = 22 });
            products.Add(new Product() { Id = 3, Name = "Tuất",Quantity = 13, Price = 23 });
            products.Add(new Product() { Id = 4, Name = "Mùi", Quantity = 14, Price = 24 });
            products.Add(new Product() { Id = 5, Name = "Dần", Quantity = 15, Price = 25 });
            products.Add(new Product() { Id = 6, Name = "Dậu", Quantity = 16, Price = 26 });
            products.Add(new Product() { Id = 7, Name = "Mão", Quantity = 17, Price = 27 });
            products.Add(new Product() { Id = 8, Name = "Thân",Quantity = 18, Price = 28 });
            products.Add(new Product() { Id = 9, Name = "Rồng",Quantity = 19, Price = 29 });
            products.Add(new Product() { Id = 10, Name = "Bé Na",Quantity = 20, Price = 40 });

        }
        //Method Syntax
        public List<Product> FilterProductsByPrice(double price1, double price2)
        {
            return products.Where(p=>p.Price>=price1 && p.Price<=price2)
                .ToList();
        }
        public List<Product> FilterProductsByPrice2(double price1, double price2)
        {
            var result = from x in products
                         where x.Price > price1 && x.Price <= price2
                         select x;
                         return result.ToList();

        }

        public List<Product>SortProductByPriceDES()
        {
            return products.OrderByDescending(p => p.Price)
                .ToList();


        }
        public List<Product>SortProductByPriceDES2()
        {
            var result = from p in products
                         orderby p.Price descending
                         select p;
            return result.ToList();
        }
        public double SumofProduct()
        {
            return products.Sum(p => p.Quantity * p.Price);
        }
    }
}
