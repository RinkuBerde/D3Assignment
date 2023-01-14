using System;
using System.Globalization;
using static Empoyeewage.DailyWage;

namespace Empoyeewage
{
    internal class EmpWageMonth
    {   
        public static void Main(string[] args)
        {
            /*  //UC-9 Total Wage for Each Company
               UC9EmpWageObject dmart = new UC9EmpWageObject("Dmart", 20, 20, 100);
               UC9EmpWageObject reliance = new UC9EmpWageObject("Reliance", 20, 23, 210);
               dmart.computeEmpWage();
               Console.Write(dmart.toString());
               reliance.computeEmpWage();
               Console.WriteLine(reliance.toString());

               //UC-10 manage Employee Wage of multiple companies
               EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
               empWageBuilder.addCompanyEmpWage("DMart", 20, 20, 100);
               empWageBuilder.addCompanyEmpWage("Reliance", 10, 30, 200);
               empWageBuilder.computeEmpWage();

               //UC-11 Employee Wage of multiple companies using API approach
               EmpWageBuilder1 empWageBuilder1 = new EmpWageBuilder1();
               empWageBuilder1.addCompanyEmpWage("DMart", 20, 25, 100);
               empWageBuilder1.addCompanyEmpWage("Reliance", 10, 40, 210);
               empWageBuilder1.computeEmpWage();
               Console.WriteLine("total wage : " + empWageBuilder1.getTotalWage("Dmart"));
               Console.WriteLine("total wage : " + empWageBuilder1.getTotalWage("Dmart"));*/

            //UC-12 list of multiple companies
              EmpWageBuilderArray1 empWageBuilder = new EmpWageBuilderArray1();
              empWageBuilder.AddCompanyEmpWage("Reliance", 20, 10, 100);
              empWageBuilder.AddCompanyEmpWage("Dmart", 20, 20, 110);
              empWageBuilder.ComputeEmpWage();

            //Store the Daily Wage
            EmpWageBuilder empWageBuilder1 = new EmpWageBuilder();
            empWageBuilder1.AddCompanyEmpWage("Reliance", 20, 20, 100);
            empWageBuilder1.AddCompanyEmpWage("Dmart", 20, 30, 120);
            empWageBuilder1.ComputeEmpWage();
            Console.WriteLine($"Total wage for Reliance Company : {empWageBuilder1.getTotalWage1("Reliance")}");
        }



    }
    
}



