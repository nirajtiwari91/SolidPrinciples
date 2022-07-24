using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProjectConsole
{
    //O: Open closed Principle (OCP)
    //OCP says that classes, methods, modules etc.are open for extension,
    //but closed for modification.

    //class Employee
    //{
    //    public double CalculateBonus(string emptype, double salary)
    //    {
    //        double bonus=0;
    //        if (emptype == "CompanyEmployee")
    //        {
    //            bonus = ((salary * 0.10) / 100);
    //        }
    //        else if (emptype == "ContractEmployee")
    //        {
    //            bonus = 0;
    //        }
    //        else if (emptype == "ThirdParty")
    //        {
    //            bonus = 0;
    //        }
    //        return bonus;
    //    }
    //}

    abstract class Bonus
    {
        public abstract double CalculateBonus(double salary);
    }

    class CompanyEmployee: Bonus
    {
        public override double CalculateBonus(double salary)
        {
            return ((salary * 0.10) / 100);
        }
    }

    class ContractEmployee : Bonus
    {
        public override double CalculateBonus(double salary)
        {
            return 0;
        }
    }

    class ThirdParty : Bonus
    {
        public override double CalculateBonus(double salary)
        {
            return 0;
        }
    }


}
