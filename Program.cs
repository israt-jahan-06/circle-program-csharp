// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

class Test
{
    public static void Main(string[] args)
    {
        double radius = Convert.ToDouble(Console.ReadLine());
        double circumference = Convert.ToDouble(2 * Math.PI * radius);
        double area = Convert.ToDouble(Math.PI*radius*radius);
        Console.WriteLine("Circumference:"+circumference+"and Area:"+area);
        Console.ReadKey();
    }
}


