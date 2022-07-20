using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    //Класс контейнер чтобы отдавать в методах апи
    public class CustomerDto : LegalEntityBase
    {
        public CustomerDto()
        {
            Clients = new List<ClientDto>();
        }
        
        //Связанные клиенты заказчика
        public List<ClientDto> Clients { get; set; }
    }
}
