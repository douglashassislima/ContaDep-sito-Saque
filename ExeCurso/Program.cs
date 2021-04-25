using System;
using System.Globalization;

namespace ExeCurso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: "); 
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titualr = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
        }
    }
}
}
