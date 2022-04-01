using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopingExam
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new CoffeCompany(new CustomerService());
            customerManager.Save(new Customer {NationalityId="23191409728",Name="Ali Enes",Surname="Işıklı",DateTime=new DateTime(2000,6,16) });
            Console.ReadKey();
        }
    }
}
