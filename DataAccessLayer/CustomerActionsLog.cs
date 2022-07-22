using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer
{
    //
    //лог событий/действий заказчика
    //


    [Table("CustomerActionsLog")]
    public class CustomerActionsLogDb
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public CustomerActionEnum CustomerAction { get; set; }

        //Если что-то происходило в отношении клиента
        public Guid? ClientId { get;set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }



    public enum CustomerActionEnum
    {
        OpenClientCard = 0,//открыл карточку клиента
        ChangeClientCard = 1,//Сохранил данные клиента

    }
}
