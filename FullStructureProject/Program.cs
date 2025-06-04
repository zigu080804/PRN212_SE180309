using System.Text;


namespace FullStructureProject

{
class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Cha mẹ thói đời ăn ở bạc");
            Console.WriteLine("Có chồng cà chớn cũng như không !");
            Console.WriteLine("Các đối số truyền vào");

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[1]);
            }
            Console.ReadLine();

        }
    }
}
