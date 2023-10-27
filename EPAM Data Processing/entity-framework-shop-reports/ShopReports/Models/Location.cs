﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopReports.Models
{
    [Table("locations")]
    public class Location
    {
        [Column("location_id")]
        [Key]
        public int Id { get; set; }

        [Column("location_address")]
        public string Address { get; set; }

        [Column("location_city_id")]
        [ForeignKey(nameof(City))]
        public int CityId { get; set; }

        public City City { get; set; }

        public virtual IList<SupermarketLocation> Supermarkets { get; set; }
    }
}
