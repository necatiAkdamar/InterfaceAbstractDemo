using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Adapters;
using MernisServiceReference;
using System.Threading.Tasks;


namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer
            { DateOfBirth = new DateTime(1985, 3, 15), FirstName = "Necati", 
                LastName = "Akdamar", NationalityId = 12773575000 });
        }
    }
}
