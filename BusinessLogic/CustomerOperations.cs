using Common;
using DataAccessLayer;
using System;
using System.Linq;
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
            
            var c = _context.Customers.FirstOrDefault(x=>x.Id == id);
            if (c == null)
                throw new Exception($"Customer by id:{id} not found");

            var clientsIds = _context.CustomerToClient.Where(x=>x.CustomerId == id).Select(y=>y.ClientId).ToList();
            var dbClients = _context.Clients.Where(x => clientsIds.Contains(x.Id));

            var cv = new List<ClientViewDto>();

            foreach(var cl in dbClients)
            {

            }


            //в дальнейшем можно написать маринг классов
            var customer = new CustomerDto
            {
                Inn = c.Inn,
                Ogrn = c.Ogrn,
                Kpp = c.Kpp,
                JurAddress = c.JurAddress,
                FactAddress = c.FactAddress,
                LegalEntityName = c.LegalEntityName,
                ClientsViews = 
            };


            return customer;
        }
    }
}
