using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucessor e antecessor
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20000; i++)
            {


                int n1, suc, ant;

                Console.WriteLine("Digite um numero");
                n1 = int.Parse(Console.ReadLine());

                suc = n1 + 1;
                ant = n1 - 1;

                Console.WriteLine("O sucessor é : " + suc);
                Console.WriteLine("O antecessor é : " + ant);
            }
                Console.ReadLine();
            







        }
    }
}
