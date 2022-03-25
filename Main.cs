using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine("Is Self Divisor: " + Number.IsSelfDivisor(input));
        Console.Write("First Num Self Divisors of size n: ");Number.ReturnNumSelfDivisors(input, 3);
        Console.WriteLine();
        Console.WriteLine("Is prime: " + Number.IsPrime(input));
        Console.Write("First primes of n times: "); Number.ReturnPrimesAfter(input, 3);
    }
    }
}
