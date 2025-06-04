﻿// See https://aka.ms/new-console-template for more information
using System.Text;
using DemoAlias;
using Student;

Console.WriteLine("Hello, World!");

Console.OutputEncoding = Encoding.UTF8;



Student s1 = new Student();
s1.Id = 1;
s1.Name = "Kiệt";


Student s2 = new Student();
s2.Id = 2;
s2.Name = "Hào";

// Lúc này trên thanh ram sẽ cấp phát 2 ô nhớ  cho s1 và s2 để quản lý 
//s1 đổi giá trị không liên quan gì tới s2 vì
// s1 và s2 đang quản lý 2 ô nhớ khác nhau

s1 = s2;
//ta viết lệnh s1 = s2;
//Tuy nhiên về bản chất nó hoạt động như sau:
//s1 trỏ tới vùng nhớ mà s2 đang quản lý 
// chứ không phải là s1 bằng s2
//Có 2 tính huống xảy ra 
// (1) ô nhớ bên s2 giờ có thêm s1 quản lý alias ==>  (>= đối tượng quản lý) 
//* chỉ cần 1 đối tượng bị đổi thì các đối tượng khcas cũng đều bị đổi

s2.Name = "Nguyễn thị Lung Lung";
Console.WriteLine("s2 đổi tên vậy s1 có tên là gì");
Console.WriteLine(s1.Name);
//(2) ô nhớ lúc trươc mà s1 quản lý giờ k còn đối tượng nào thì 
// lúc này HDH tự động thu hồi ô nhớ Automatic garbage Collection
// túc là ta ko thể truy xuất để lấy lại giá trị s1 có id = 1 name Tèo

Product p1 = new Product()
{
    Id = 1,
    Name = "P1",
    Quantity = 10,
    Price = 20
};
Product p2 = new Product()
{
    Id = 1,
    Name = "P1",
    Quantity = 10,
    Price = 20
};
Product p3 = new Product()
{
    Id = 1,
    Name = "P1",
    Quantity = 10,
    Price = 20
};
Product p4 = new Product()
{
    Id = 1,
    Name = "P1",
    Quantity = 10,
    Price = 20
};
Product p5 = new Product()
{
    Id = 1,
    Name = "P1",
    Quantity = 10,
    Price = 20
};