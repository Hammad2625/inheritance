using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ferrari ferrari = new Ferrari();
            Console.WriteLine(ferrari.Name + " " +ferrari.Color + " " + ferrari.CarType + " " + ferrari.CarNo);

            Bugatti bugatti = new Bugatti();
            Console.WriteLine(bugatti.Name + " " + bugatti.Color + " " + bugatti.CarType + " " + bugatti.CarNo);

            Console.ReadLine();
        }
    }
}
