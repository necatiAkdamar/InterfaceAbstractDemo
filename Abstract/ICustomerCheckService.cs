using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Adapters;

namespace InterfaceAbstractDemo.Abstract
{
    public interface ICustomerCheckService//Kişinin doğruluğunu teyit eder 
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
