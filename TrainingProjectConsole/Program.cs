using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
          
        }
    }























    interface ICustomer
    {
        public void Savecustomer();
    }
    class Customer : ICustomer
    {
        public void Savecustomer()
        {
            Console.Write("This is Customer");
        }
    }

    class GuestCustomer : ICustomer
    {
        public void Savecustomer()
        {
            Console.Write("This is Guest Customer");
        }
    }
}