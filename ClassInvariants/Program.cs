using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInvariants
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Peter", 27);
            Console.WriteLine("{0} {1}", student._name, student._age);

            student._name = "";

        }



        
    }
}
