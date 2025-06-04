using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    public class Category
    {
        public int Id;
        public string Name;
        public void PrintInfor()
        {
            Console.WriteLine($"{Id}\t{Name}");
        }
    }
}