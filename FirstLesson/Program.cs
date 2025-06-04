// See https://aka.ms/new-console-template for more information

using System.Text;

Console.WriteLine("Hello, World!");

//to use Vietnamese 
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Phương trình bậc 1 ");
Console.WriteLine("Hệ số a: ");
double a = Double.Parse(Console.ReadLine());
Console.WriteLine("Hệ số b: ");
double b = Double.Parse(Console.ReadLine()); 
if(a == 0 && b == 0)
{
    //0x + 0 =0
    Console.WriteLine("Phương trình vô số nghiệm");

}
else if( a == 0  && b != 0)
{
    Console.WriteLine(" Phương trình không có nghiệm");

}
else
{
    Console.WriteLine("X={0}", -b/a);
}
