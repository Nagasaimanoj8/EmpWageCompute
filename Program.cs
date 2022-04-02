using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCompute
{

    class Program
    {
        public const int FULL_TIME = 1;     //Constant variable
        public const int PART_TIME = 2;

        public int numofCompany = 0;
        private Empclass[] EmployeeWageComputationProblemArray;

        public Program()
        {
            this.EmployeeWageComputationProblemArray = new Empclass[5];
        }
        public void addComapnyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            EmployeeWageComputationProblemArray[this.numofCompany] = new Empclass(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numofCompany++;
        }
        public void ComputeEmployeeWage()
        {
            for (int i = 0; i < numofCompany; i++)
            {
                EmployeeWageComputationProblemArray[i].setTotalEmpWage(this.ComputeEmployeeWage(this.EmployeeWageComputationProblemArray[i]));
                Console.WriteLine(this.EmployeeWageComputationProblemArray[i].toString());
            }
        }
        private int ComputeEmployeeWage(Empclass EmployeeWageComputationProblem)
        {
            int emphrs = 0;
            int empWage = 0;
            int totalempwage = 0;
            int hrs = 0;
            int workingDays = 1;
            while (emphrs <= EmployeeWageComputationProblem.maxHoursPerMonth && workingDays < EmployeeWageComputationProblem.numOfWorkingDays)
            {

                workingDays++;
                Random random = new Random();
                int EmpCheack = random.Next(0, 3);      //Random Generate 0 ,1,2
                switch (EmpCheack)          //Switch case Statment
                {
                    case FULL_TIME:         //Employee is FullTime=1
                        emphrs = 8;
                        break;
                    case PART_TIME:          //Employee is FullTime=2
                        emphrs = 4;
                        break;
                    default:
                        emphrs = 0;
                        break;
                }
                hrs += emphrs;

                Console.WriteLine("Day " + workingDays + " Emp hrs:- " + emphrs);//Display empwage

                //totalempwage = totalempwage + empWage;      //Calculate total employe month wage
                //empWage = empRatePerHour * emphrs;

            }
            return emphrs * EmployeeWageComputationProblem.empRatePerHour;
        }

    }
}