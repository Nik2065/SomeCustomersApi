using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer
{
    //
    //Связь клиенты-заказчики
    //
    [Table("CustomersToClients")]
    public class CustomerToClientDb
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Guid CustomerId { get; set; }

        [Required]
        public Guid ClientId { get; set; }

    }
}
