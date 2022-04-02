using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCompute
{
    internal class EmpMain
    {
        public static void Main(String[] args)
        {
            Program empWageBuilder = new Program();   //Create object of class
            empWageBuilder.addComapnyEmpWage("Dmart", 20, 2, 10);  //call method
            empWageBuilder.addComapnyEmpWage("Relicance", 10, 4, 20); //call method
            empWageBuilder.ComputeEmployeeWage(); //call method
            Console.ReadLine();
        }

    }
}
