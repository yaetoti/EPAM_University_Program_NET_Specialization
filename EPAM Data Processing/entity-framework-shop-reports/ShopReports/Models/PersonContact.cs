﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopReports.Models
{
    [Table("person_contacts")]
    public class PersonContact
    {
        [Column("person_contact_id")]
        [Key]
        public int Id { get; set; }

        [Column("person_id")]
        [ForeignKey(nameof(Person))]
        public int PersonId { get; set; }

        [Column("contact_type_id")]
        [ForeignKey(nameof(ContactType))]
        public int ContactTypeId { get; set; }

        [Column("contact_value")]
        public string Value { get; set; }

        public Person Person { get; set; }

        public ContactType Type { get; set; }
    }
}
