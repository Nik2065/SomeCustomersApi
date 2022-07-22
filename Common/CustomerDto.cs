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
            ClientsViews = new List<ClientViewDto>();
        }
        
        //Связанные клиенты заказчика в упрощенном виде
        public List<ClientViewDto> ClientsViews { get; set; }
    }
}
