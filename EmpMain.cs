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
            Program EmployeeWageBuilder = new Program("BridgeLabzs", 25, 22, 90);
            Program flipkartEmployeeWageBuilder = new Program("Flipkart", 40, 18, 100);
            Program amazonEmployeeWageBuilder = new Program("Amazon", 45, 24, 110);
            Program thoughtworksEmployeeWageBuilder = new Program("ThoughtWorks", 30, 20, 120);
            Console.WriteLine(EmployeeWageBuilder.toString());
            EmployeeWageBuilder.ComputeEmployeeWage();
            Console.WriteLine(flipkartEmployeeWageBuilder.toString());
            flipkartEmployeeWageBuilder.ComputeEmployeeWage();
            Console.WriteLine(amazonEmployeeWageBuilder.toString());
            amazonEmployeeWageBuilder.ComputeEmployeeWage();
            Console.WriteLine(thoughtworksEmployeeWageBuilder.toString());
            thoughtworksEmployeeWageBuilder.ComputeEmployeeWage();
            Console.ReadLine();
        }

    }
}
