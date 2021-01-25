using InterfaceAbstractDemo.Abstract;
using System;

namespace InterfaceAbstractDemo.Abstract
{
    public class Customer:IEntity//Genel Müşteri Özellikleri IEntity varlığımız demek veritabanında
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long NationalityId { get; set; }
    }
}
