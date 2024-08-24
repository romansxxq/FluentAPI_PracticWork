using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI.Entities
{
    public class Shop
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public int ParkingArea { get; set; }
        public ICollection<Worker> Workers { get; set; }
    }
}
