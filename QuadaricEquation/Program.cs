
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
for (int k = 2; k > 8 && k <= 50; k++)
{

}
    void first_degree_solution(double a,double b)
{
    if (a == 0 && b == 0)
        Console.WriteLine("Vô số Nghiệm");
    else if (a == 0 && b != 0)
        Console.WriteLine("Chương trình vô nghiệm");
    else Console.WriteLine("chương trình như cuc");

      
    
    //Console.WriteLine("Phương trình bậc 1 ");
    //Console.WriteLine("Hệ số a: ");
    //double a = Double.Parse(Console.ReadLine());
    //Console.WriteLine("Hệ số b: ");
    //double b = Double.Parse(Console.ReadLine());
}
 void quadratic_equatrion(double a,double b, double c) 
{
    if(a==0)
        first_degree_solution(b,c);
    else
    {
        var delta = Math.Pow(b, 2) - 4 * a * c;
        if(delta < 0 )
        {
            Console.WriteLine("Chương trình vô nghiệm");
        }
        else if(delta == 0)
        {
            Console.WriteLine("Chương trình có nghiệm kép", "X1=X2={0}", -b/2*a);
        }
        else
        {
            var x1 = (-b-Math.Sqrt(delta))/(2*a);
            var x2 = (-b + Math.Sqrt(delta))/(2*a);
            Console.WriteLine("X1={0} \n X2={1}", x1, x2);
        }
        // Một ví dụ về var khi chúng ta chưa xác định được giá trị của kết quả 
    }    
}
Console.WriteLine("Phương trình bậc 2: ax^2 +bx + c");
Console.WriteLine("Hệ số a: ");
var a = Double.Parse(Console.ReadLine());
Console.WriteLine("Hệ số b: ");
var b = Double.Parse(Console.ReadLine());
Console.WriteLine("Hệ số c: ");
var c = Double.Parse(Console.ReadLine());
quadratic_equatrion(a, b, c);
Console.ReadLine();
