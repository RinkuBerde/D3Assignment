using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empoyeewage
{
        internal class CompanyEmpWage
        {
            public string company;
            public int empRatePerHour;
            public int numOfWorkingDays;
            public int maxHourPerMonth;
            public int totalEmpWage;

            public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHourPerMonth)
            {
                this.company = company;
                this.empRatePerHour = empRatePerHour;
                this.numOfWorkingDays = numOfWorkingDays;
                this.maxHourPerMonth = maxHourPerMonth;
            }
            public void setTotalEmpWage(int totalEmpWage)
            {
                this.totalEmpWage = totalEmpWage;
            }
            public string toString()
            {
                return "Total Emp Wage for company:" + this.company + " is " + this.totalEmpWage;
            }
        }

        public class EmpWageBuilderArray
        {
            //Declaring Constant Variable
            public const int FULL_TIME = 1;
            public const int PART_TIME = 2;
            private int numOfCompany = 0;
            private CompanyEmpWage[] companyEmpWageArray;

            public EmpWageBuilderArray()
            {
                this.companyEmpWageArray = new CompanyEmpWage[5];
            }
            public void addCompanyEmpWage(string company, int empRatePerhour, int numOfWorkingDays, int maxHoursPerMonth)
            {
                companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerhour, numOfWorkingDays, maxHoursPerMonth);
                numOfCompany++;
            }
            public void computeEmpWage()
            {
                for (int i = 0; i < numOfCompany; i++)
                {
                    companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                    Console.WriteLine(this.companyEmpWageArray[i].toString());
                }
            }
            private int computeEmpWage(CompanyEmpWage companyEmpWage)
            {
                //Console.WriteLine("Welcome to employee wage computation");
                //Creating a Random Function
                int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
                while (totalEmpHrs <= companyEmpWage.maxHourPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
                {
                    //Calling the next method in Random Class
                    totalWorkingDays++;
                    Random random = new Random();
                    int empCheck = random.Next(0, 3);
                    switch (empCheck)
                    {
                        case FULL_TIME:
                            empHrs = 4;
                            break;
                        case PART_TIME:
                            empHrs = 8;
                            break;
                        default:
                            empHrs = 0;
                            break;

                    }
                    totalEmpHrs += empHrs;
                    Console.WriteLine("Days : " + totalWorkingDays + " Emp Hours : " + empHrs);

                }
                return totalEmpHrs * companyEmpWage.empRatePerHour;


            }
        }
}
