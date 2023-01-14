using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empoyeewage
{
  
   
        class CompanyEmpWage
    {
            //properties 
            public string company;
            public int wagePerHour;
            public int numWorkingDays;
            public int maxHoursPerMonth;
            public int totalWage;


            public CompanyEmpWage(string company, int wagePerHour, int numWorkingDays, int maxHoursPerMonth)
            {
                //Constructor
                this.company = company;
                this.wagePerHour = wagePerHour;
                this.numWorkingDays = numWorkingDays;
                this.maxHoursPerMonth = maxHoursPerMonth;
            }

            public void SetTotalEmpWage(int totalEmpWage)
            {
                this.totalWage = totalEmpWage;
            }

            public string Result()
            {
                return "Total Employee wage for Comapny : " + this.company + " is " + this.totalWage;
            }
        }
    
}
