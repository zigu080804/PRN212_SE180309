using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int[] arr = { 20, 11, 30, 15, 30, 45, 73, 69, 22 };

/* Câu 1: Lọc ra các số chẵn 
 * 
 * Cách 1 Dùng Extension Method - Method Syntax
 * 

 */
var ar_chan = arr.Where(x => x % 2 == 0);
Console.WriteLine("Các số chẵn trong danh sách : ");
ar_chan.ToList().ForEach(x => Console.WriteLine(x));
//Cách 2 dùng Query syntax
var ar_chan2 = from x in ar_chan
               where x % 2 == 0
               select x;
Console.WriteLine("Các số chẵn - Query Syntax: ");
ar_chan2.ToList().ForEach(x => Console.WriteLine(x));

/* Câu 2: Tăng các phần tử lên 2 đơn vị 
 */
var arr2 = arr.Where(x => x % 2 != 0)
              .Select(x => x + 2);
Console.WriteLine("Dữ liệu gốc");
foreach (var x in arr2)
    Console.Write(x + "\t");
Console.WriteLine("Sau khu tăng số lẻ");
foreach(var x in arr) Console.Write(x + "\t");

/* Câu 3: Sắp xếp các phần tử tăng dần
 */
var arr4 = arr.OrderBy(x=>x);
var arr5 = from x in arr
           orderby x
           select x;
Console.WriteLine("\nSau khi sắp tăng dần: ");
foreach (var item in arr5)
{
    Console.Write(item + "\n");
}    


//Câu 4: Sắp xếp giảm dần

var arr6 = arr.OrderByDescending(x => x);
var arr7 = from x in arr
           orderby x descending
           select x;

//Câu 5
Console.WriteLine("Số lẻ là  =" + arr.Where(x => x % 2 != 0).Count());
int sole = (from x in arr
            where x % 2 != 0
            select x).Count();
Console.WriteLine("Số lẻ"+ sole);
