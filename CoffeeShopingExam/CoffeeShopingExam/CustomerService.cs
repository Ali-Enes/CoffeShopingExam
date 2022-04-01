using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopingExam
{
    class CustomerService : ICustomerCheckService
    {
        public bool ValidateCustomer(Customer customer)
        {
            ServiceReference.KPSPublicSoapClient client = new ServiceReference.KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId),customer.Name,customer.Surname,customer.DateTime.Year);
        }
    }
}
