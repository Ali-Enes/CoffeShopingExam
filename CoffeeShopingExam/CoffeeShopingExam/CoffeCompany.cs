using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopingExam
{
    class CoffeCompany : BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;

        public CoffeCompany(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.ValidateCustomer(customer))
            {
                base.Save(customer);
            }
            else
            {
                Console.WriteLine("no such that person");
            }
        }
    }
}
