// See https://aka.ms/new-console-template for more information
using System.Text;
using OOP2;
using OOP2_Reuse_As_Library;

Console.WriteLine("Hello, World!");
Console.OutputEncoding = Encoding.UTF8;

FulltimeEmployee e1 = new FulltimeEmployee();
e1.Id = 1;
e1.Name = "Tèo";
e1.birthday = new DateTime(1990, 12, 13);
e1.IdCard = "SE180309";

Console.WriteLine("thông tin của tèo");
Console.WriteLine(e1);
Console.WriteLine("==>AGE=" + e1.Tinhtuoi);