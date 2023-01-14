using System;
using System.Globalization;

namespace Empoyeewage
{
    internal class EmpWageMonth
    {   
        public static void Main(string[] args)
        {
            UC9EmpWageObject dmart = new UC9EmpWageObject("Dmart", 20, 20, 100);
            UC9EmpWageObject reliance = new UC9EmpWageObject("Reliance", 20, 23, 210);
            dmart.computeEmpWage();
            Console.Write(dmart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());


        }
    }
}



