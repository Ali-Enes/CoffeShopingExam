﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopingExam
{
    interface ICustomerCheckService
    {
        bool ValidateCustomer(Customer customer);
    }
}
