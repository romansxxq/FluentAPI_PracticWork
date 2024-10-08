﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI.Entities
{
    public class City
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required, MaxLength(100)]
        public Country Country { get; set; }
        public int CountryId { get; set; }
        [Required, MaxLength(100)]

        public ICollection<Shop> Shops { get; set; }
    }
}
