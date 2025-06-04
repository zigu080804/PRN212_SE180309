using System.Text;
using DemoLinQtoObject2;

Console.OutputEncoding = Encoding.UTF8;

ListProduct lp = new ListProduct();
lp.gen_products();
//Câu 1: Lọc ra các sản phẩm có giá từ A ->  B 
//Sử dụng Method Syntax và Query Syntax


var result1 = lp.FilterProductsByPrice(200, 300);
Console.WriteLine("Danh sách sản phẩm có giá từ 200-300");
result1.ForEach(x => Console.WriteLine(x));

//Câu 2 : Sắp xếp các sản phẩm theo đơn giá 
//Sử dụng Method Syntax and Query Syntax
var result2 = lp.SortProductByPriceDES();
Console.WriteLine("Danh sách các sản phẩm sau khi sắp xếp");
result2.ForEach(x => Console.WriteLine(x));

//Câu 3: Tính tổng giá trị sản phẩm trong kho hàng 
Console.WriteLine("tổng giá trị " + lp.SumofProduct());