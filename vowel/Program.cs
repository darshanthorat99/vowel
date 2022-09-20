using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace vowel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the alphabet");
            Char ch = Convert.ToChar(Console.ReadLine());
                if(ch == 'a'|| ch == 'e'||ch =='i'|| ch =='o'||ch =='u')
            {
                Console.WriteLine($"{ch} is vowel");
            }
            else
            {
                Console.WriteLine("not a vowel");
            }
        }
    }
}
