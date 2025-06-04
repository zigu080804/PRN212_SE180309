// See https://aka.ms/new-console-template for more information
using System.Text;
using OOP2;

Console.WriteLine("Hello, World!");

Console.OutputEncoding = Encoding.UTF8;

/* 
 * Sử dụng Generic List để quản lý nhân sự 
 * thể hiện đầy đủ CRUD
 * C->Create --> thêm mới nhân sự
 * R-->Read/Retrieve -->  Đọc / truy vấn dữ liệu
 * U-->Update chỉnh sửa dữ liệu
 * D--> Xóa dữ liệu
 */
//câu 1 - Create
//Dùng list để tạo 5  Employee , trong đó 4 Employee là chính thức 
// và 1 Employee là thời vụ
List<Employee> employees = new List<Employee>();
FulltimeEmployee e1 = new FulltimeEmployee();
e1.Id = 1;
e1.Name = "Name 1";
e1.IdCard = "Card 1";
e1.birthday = new DateTime(1993, 2, 21);
employees.Add(e1);

FulltimeEmployee e2 = new FulltimeEmployee();
e2.Id = 2;
e2.Name = "Name 2";
e2.IdCard = "Card 2";
e2.birthday = new DateTime(1993, 12, 21);
employees.Add(e2);
FulltimeEmployee e3 = new FulltimeEmployee();
e3.Id = 3;
e3.Name = "Name 3";
e3.IdCard = "Card 3";
e3.birthday = new DateTime(1993, 8, 21);
employees.Add(e3);

FulltimeEmployee e4 = new FulltimeEmployee();
e4.Id = 2;
e4.Name = "Name 4";
e4.IdCard = "Card 4";
e4.birthday = new DateTime(1993, 1, 21);
employees.Add(e4);

ParttimeEmployee e5 = new ParttimeEmployee();
e5.Id = 2;
e5.Name = "Name 5";
e5.IdCard = "Card 5";
e5.birthday = new DateTime(1993, 6, 21);
employees.Add(e5);

//Câu 2 
//     R-->  Xuất ra toàn bộ nhân sự 

Console.WriteLine("----Danh sách nhân sự -cách 1----------");
employees.ForEach(e => Console.WriteLine(e)) ;
Console.WriteLine("----Danh sách nhân sự -cách 2----------");
foreach (var e in employees)
    Console.WriteLine(e);
//Câu 3 
//  R --> Lọc ra nhân sự chính thức và tính tổng lương
//cách 1 dùng cách extension method của hệ thống 
List<FulltimeEmployee> fe_list = employees.OfType<FulltimeEmployee>().ToList();
Console.WriteLine("-------Danh sách thông tin nhân viên cách 1---------------");
fe_list.ForEach(e => Console.WriteLine(e));

//cách 2: 
List<FulltimeEmployee> fe_list2 = new List<FulltimeEmployee>();
foreach (var e in employees)
{
    if(e is FulltimeEmployee)
        fe_list2.Add(e as FulltimeEmployee);
}

Console.WriteLine("---Danh sách thông tin nhân viên chính thức cách 2----");
fe_list2.ForEach(e => Console.WriteLine(e));


double sum_salary = fe_list2.Sum(e => e.calSalary());
Console.WriteLine("Tổng lương = " + sum_salary);
//Câu 4 R-->  Sắp xếp danh sách nhân sự theo ngày tháng năm sinh
for(int i = 0;i< employees.Count;i++)
{
    for (int j = 0; j < employees.Count; j++)
    {
        Employee ei = employees[i];
        Employee ej = employees[j];
        if(ei.birthday > ej.birthday)
        {
            employees[i] = ej;
            employees[j] = ei;
        }    
    }    
}
Console.WriteLine("---danh sách nhân sự sau khi săp xếp ---");
employees.ForEach(e => Console.WriteLine(e));