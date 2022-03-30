﻿using System;
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
            int workingHrs = 0;
            int empHrs = 0;
            int empWage = 0;
            int totalWage = 0;
            int day = 1;
            Random random = new Random();
            //for (int day = 1; day <= MAX_WORKING_DAYS; day++)
            while (day <= MAX_WORKING_DAYS && workingHrs <= MAX_WORKING_HRS)
            {
                int empInput = random.Next(0, 3);
                switch (empInput)
                {
                    case isFullTime:
                        Console.WriteLine("employee is present");
                        empHrs = 8;
                        break;
                    case isPartTime:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = EMP_RATE_PER_HR * empHrs;
                Console.WriteLine("Daily Wage:{0} is:{1}", empWage);
                totalWage += empWage;
                day++;
                workingHrs += empHrs;
            }
            Console.WriteLine("Total wage for {0} days is :{1} and workingHrs{2}",totalWage, workingHrs);
            Console.ReadLine(); ;
             
            }
        }
    }


