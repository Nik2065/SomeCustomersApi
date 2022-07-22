using Common;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    interface ICustomerOperations
    {
        CustomerDto GetCustomer(Guid id);
    }


    public class CustomerOperations : ICustomerOperations
    {
        public CustomerOperations(ScDataContext context)
        {
            _context = context;
        }

        ScDataContext _context;

        public CustomerDto GetCustomer(Guid id)
        {

        }
    }
}
