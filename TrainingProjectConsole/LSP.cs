using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    //L: Liskov substitution Principle(LSP)
    //if we can successfully replace the object/instance of a parent class with the object/instance
    //of the child class, without affecting the behavior of the base class, then it is said to be
    //in Liskov Substitution Principle.



    interface Salary
    {
        double Salary();
    }

    interface Bonus
    {
        double CalculateBonus(double salary);
    }

    class CompanyEmployee : Salary, Bonus
    {
        public double Salary()
        {
            return 10000;
        }
        public double CalculateBonus(double salary)
        {
            return ((salary * 0.10) / 100);
        }
    }

    class ContractEmployee : Salary, Bonus
    {
        public double Salary()
        {
            return 5000;
        }
        public double CalculateBonus(double salary)
        {
            return 0;
        }
    }

    class ThirdPartyEmployee : Salary
    {
        public double Salary()
        {
            return 5000;
        }
    }


}
