using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCompute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage");
            const int isFullTime = 1;
            const int isPartTime = 2;
            const int MAX_WORKING_DAYS = 20;
            const int EMP_RATE_PER_HR = 20;
            const int MAX_WORKING_HRS = 100;
            int empHrs = 0;
            int empWage = 0;
            int totalempWage = 0;
            int hrs = 0;
            int day = 1;
            Random random = new Random();  //Random Class
            //for (int day = 1; day <= MAX_WORKING_DAYS; day++)
            while (hrs <= MAX_WORKING_HRS && day <= MAX_WORKING_DAYS)
            {
                int empInput = random.Next(0, 3);  //Random Generate 0,1,2
                switch (empInput) //Switch case Statement
                {
                    case isFullTime:      //Employee is FullTime=1
                        Console.WriteLine("employee is present");
                        empHrs = 8;
                        break;
                    case isPartTime:    //Employee is PartTime=2
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                //Calaculate empwage
                empWage = EMP_RATE_PER_HR * empHrs;
                //Display emp Wage
                Console.WriteLine("Daily Wage:{0} is:{1}", empWage);
                totalempWage += empWage;
                day++;
                hrs += empHrs;
            }
            Console.WriteLine("Total Employee Month Wage :" +totalempWage);
            Console.WriteLine("Employee Wage For " + day + "days" + totalempWage);
            Console.WriteLine("Working hours" +hrs);
            }
        }
    }


