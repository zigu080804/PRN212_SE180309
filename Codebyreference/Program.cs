using System.Text;

void ham1(int n)
{
    n = 8;
    Console.WriteLine($"n trong ham = {n}");
}
Console.OutputEncoding = Encoding.UTF8;

int n = 5;
Console.WriteLine($"n truoc khi vao ham = {n}");
ham1(n);
Console.WriteLine($"n sau khi vao ham = {n}");


void ham2 (ref int n)
{
    n = 8;
    Console.WriteLine($"n trong khi vao ham = {n}");

}
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine($"n truoc khi vao ham = {n} ");
ham2 (ref n);
Console.WriteLine($"n sau khi vao ham = {n} ");

// ref phải khởi tạo giá trị cho biến trước khi gọi nếu chỉ khai báo int m and ref m (wrong)
// ref and out đều có khả năng tham biến có nghĩa là giá trị sẽ đổi 

void ham3 (out int n)
{
    n = 8;
}



