// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
using System.Text;
using OOP5_Dictionary;

Console.WriteLine("Hello, World!");

Console.OutputEncoding = Encoding.UTF8;

Category c1 = new Category();

c1.Id = 1;
c1.Name = "Nước ngot";
Product p1 = new Product();

p1.Id = 1;
p1.Name = "Coca";
p1.Quantity = 10;
p1.Price = 15;
c1.AddProduct(p1);

Product p2 =  new Product();
p2.Id = 2;
p2.Name = "Pepsi";
p2.Quantity = 30;
p2.Price = 15;
c1.AddProduct(p2);


Product p3 = new Product();
p3.Id = 3;
p3.Name = "String";
p3.Quantity = 200;
p3.Price = 150;
c1.AddProduct(p3);

Product p4 = new Product();
p4.Id = 4;
p4.Name = "Bò Húc";
p4.Quantity = 230;
p4.Price = 13;
c1.AddProduct(p4);

Product p5 = new Product();
p5.Id = 2;
p5.Name = "Trà Đài";
p5.Quantity = 34;
p5.Price = 20;
c1.AddProduct(p5);


Console.WriteLine("------Xuất toàn bộ sản phẩm của Nước ngọt------")
; c1.PrintAllProducts();

//Lọc ra các sản phẩm có giá từ X --> y

Console.WriteLine("----Bảng nước ngọt sau khi lọc ra----");
Dictionary<int, Product> filter = c1.FlterProductByPrice(10, 20);
Console.WriteLine("--Các sản phẩm có giá từ 10-20--");
foreach(KeyValuePair<int, Product> kvp in filter)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}


Dictionary<int, Product> SortIncrease = c1.FilterIncreasingByPrice();
Console.WriteLine("--Các sản phẩm sau khi sắp xếp--");
foreach (KeyValuePair<int, Product> kvp in SortIncrease)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}

Dictionary<int, Product> SortBy2field = c1.FilterIncreasingByPrice();
foreach (KeyValuePair<int, Product> kvp in SortBy2field)

{
    Product p = kvp.Value;
    Console.WriteLine("--Sắp xếp giảm dần theo số lượng và tăng dần theo giá");
    Console.WriteLine(p);
}

Console.WriteLine("--Sản phẩm trước khi chỉnh sửa--");
Console.WriteLine(p1);
p1.Name = "Xá xị";
p1.Quantity = 20;
p1.Price = 20;
c1.UpdateProduct(p1);
Console.WriteLine("Sản phẩm sau khi chỉnh sửa");
Console.WriteLine(p1);


Console.WriteLine("--Danh sách sản phẩm trước khi điều chỉnh--");
c1.PrintAllProducts();
int id = 1;
bool ret = c1.RemoveProduct(id);
if (ret)
{
    Console.WriteLine($"--Đã xóa sản phẩm có mã {id} thành công--");
    c1.PrintAllProducts();
}
else
{
    Console.WriteLine($"--Không tìm thấy sản phẩm {id} chóa nào để xóa--");
} 

Category c2 = new Category();
c2.Id = 2;
c2.Name = "Beer";
c2.AddProduct(new Product()
{
    Id = 6,
    Name = "Sài gòn",
    Quantity = 20,
    Price = 19,
});
c2.AddProduct(new Product()
{
    Id = 7,
    Name = "3333",
    Quantity = 30,
    Price = 18,
});
c2.AddProduct(new Product()
{
    Id = 8,
    Name = "Heniken",
    Quantity = 22,
    Price = 22,
});
LinkedList<Category> ss = new LinkedList<Category>();
ss.AddLast(c1);
ss.AddLast(c2);
Console.WriteLine("Toàn bộ dữ liệu của danh mục");
foreach(Category c in ss)
{
    Console.WriteLine($"--{c.Name}");
    Console.WriteLine("**************");
    c.PrintAllProducts();
    Console.WriteLine("**************");
}    