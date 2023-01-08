using System;
using System.Globalization;

namespace Empoyeewage
{
    internal class EmpWageMonth
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public static int computeEmpwage(string company, int empRatePerHour, int numofWorkingDays, int maxHoursPerMonth)
        {
            //variable
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numofWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days#:" + totalWorkingDays + "Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp wage: " + totalEmpWage);
            return totalEmpWage;
        }
        
        public static void Main(string[] args)
        {
            computeEmpwage("DMart",20,20,100);
            computeEmpwage("Reliance", 10, 4, 20);
        }
    }
}



