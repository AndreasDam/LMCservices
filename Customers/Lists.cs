﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using API;

namespace Customers
{
    public class CompanyCustomers : API.Lists<CompanyCustomer>
    {
        public CompanyCustomers() 
            : base()
        {
        }
    }

    public class PrivateCustomers : API.Lists<PrivateCustomer>
    {
        public PrivateCustomers()
            : base() 
        {
        }
    }
}
