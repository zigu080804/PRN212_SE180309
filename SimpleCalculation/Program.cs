

//to use Vietnamese 
//using..  sử dụng thư viện 
using System.Text;
//namespace
Console.OutputEncoding = Encoding.UTF8;

void do_calculate(double a, double b,String op)
{
    switch(op)
    {
        case "+":
            Console.WriteLine("{0} + {1} ={2}", a, b, a+b);
            break;
        case "-":
            Console.WriteLine("{0} - {1} ={2}", a, b, a - b);
            break;
        case "*":
            Console.WriteLine("{0} * {1} ={2}", a, b, a * b);
            break;
        case "/":
            Console.WriteLine("{0} / {1} ={2}", a, b, a/b);
            break;
        default:
            Console.WriteLine("Nhap lui a");
            break;
    }
}
Console.WriteLine("SIMPLE CALCULATION!!");
Console.WriteLine("Nhập số a");
double a = Double.Parse(Console.ReadLine());
Console.WriteLine("Nhập số b");
double b = Double.Parse(Console.ReadLine());
Console.WriteLine("Nhập phép toán ");
String op = Console.ReadLine(); 
do_calculate(a, b, op);
Console.ReadLine();