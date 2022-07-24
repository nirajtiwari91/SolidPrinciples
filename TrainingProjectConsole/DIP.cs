using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    //D: Dependency Inversion Principle(DIP)
    //DIP Says High-level modules should not depend on low-level modules.Instead,
    //both should depend on abstractions (interfaces).

    //class Employee
    //{
    //    public void SaveEmployee()
    //    {
    //        EMPDataAccessLayer objDataAccess = new EMPDataAccessLayer();
    //        objDataAccess.SaveEmployee();
    //    }
    //}

    //class EMPDataAccessLayer
    //{
    //    public void SaveEmployee()
    //    {
    //        //Save method 
    //    }
    //}

    public interface IEMPDataAccessLayer
    {
        public void SaveEmployee();
    }

    public class EMPDataAccessLayer : IEMPDataAccessLayer
    {
        public void SaveEmployee()
        {
            //Code for save employee
        }
    }

    public class Employee
    {
        private readonly IEMPDataAccessLayer _EMPDataAccessLayer;
        public Employee(IEMPDataAccessLayer EMPDataAccessLayer)
        {
            _EMPDataAccessLayer = EMPDataAccessLayer;
        }
        public void SaveEmployee()
        {
            _EMPDataAccessLayer.SaveEmployee();
        }
    }
}
