using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)//virtual ile ICustomerService den implement ettiğimiz save i starbucksda kullanırken override(düzenleme) edebiliriz.
        {
            Console.WriteLine("Veri Tabanına Kaydedildi: "+ customer.FirstName);
        }
    }
}
