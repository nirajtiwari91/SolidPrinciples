using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TrainingProjectConsole
{
    //S: Single Responsibility Principle(SRP)
    //SRP says that each class, module, or function in your program should only do one job.
    //In other words, each should have full responsibility for a single functionality of the program.
    class customer
    {
        public void SaveCustomer()
        {
            sqlconnection.createcon();

            //Save logic
            //Param1
            //Param2

            Emailer.sentemail();

            Logger.WriteLog();
        }

        public void saveEmployee()
        {

        }
    }

    static class sqlconnection
    {
        public static void createcon()
        {

        }
    }

    static class Emailer
    {
        public static void sentemail()
        {

        }
    }

    static class Logger
    {
        public static void WriteLog()
        {

        }
    }
}
