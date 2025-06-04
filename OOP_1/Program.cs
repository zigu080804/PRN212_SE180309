using OOP_1;
Category cat    = new Category();
cat.Name = "Test";
cat.Id = 1;

cat.PrintInfor();








Employee e1 = new Employee();
e1.Id = 1;
e1.IdCard = "03023";
e1.Name = "Ten";
e1.Email = "@gmail";
e1.Phone = "0949564231";

e1.printInfor();

Employee e2 = new Employee()

{
    Id = 1,
    IdCard = "0333",
    Name = "Test",
    Email = "@",
    Phone = "0949564231"
};
Console.WriteLine(e2);
e2.printInfor();


Employee e3 = new Employee()
{
    Id = 1,
    Name = "Test",
    IdCard = "",
    Email = "@",
    Phone = "0948484"
};
e3.printInfor();
//hoặc tự động gọi to String khi đối tượng được xuất ra màn hình
Console.WriteLine(e3);
// e4 sẽ xuất kết quả con constructor mặc định 
Employee e4 = new Employee();
e4.printInfor();

Customer c1 = new Customer();

c1.PrintInfor();