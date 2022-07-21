﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer
{
    [Table("Customers")]
    public class CustomerDb
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string LegalEntityName { get; set; }

        [Required]
        public string Ogrn { get; set; }

        [Required]
        public string Inn { get; set; }

        [Required]
        public string Kpp { get; set; }

        [Required]
        public string JurAddress { get; set; }

        [Required]
        public string FactAddress { get; set; }

        public List<ClientsDb> Clients { get; set; }

    }
}
