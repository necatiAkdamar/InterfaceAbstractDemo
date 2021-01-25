using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;

namespace InterfaceAbstractDemo.Concrete
{
    class CustomerCheckManager : ICustomerCheckService

    {
        public bool CheckIfRealPerson(Customer customer)
        {
                        
            return true;//kişinin doğrulandığını varsayıp true döndürüyoruz. fake doğrulama classı, kendi servisimiz
        }
    }
}
