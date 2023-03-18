using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kelime ve indeks girin:");
            string input = Console.ReadLine();

            string[] input2 = input.Split(','); 
            string c = input2[0]; 
            int t = Convert.ToInt32(input2[1]); 
            string e = c.Remove(t, 1); 

            Console.WriteLine(e);
        }
    }
}
