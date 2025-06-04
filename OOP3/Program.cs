// See https://aka.ms/new-console-template for more information
using System.Text;
using OOP3;

Console.WriteLine("Hello, World!");

Console.OutputEncoding = Encoding.UTF8;

int n1 = 5;
Console.WriteLine("Tổng từ 1 đến 5 =" + n1.TongTu1toiN());

int[]arr = new int[8];
arr.TaoMang();
Console.WriteLine("Mảng trước khi sắp xếp:");
arr.XuatMang();

arr.SapXepTangDan();
Console.WriteLine($"{arr.SapXepTangDan}");
arr.XuatMang();