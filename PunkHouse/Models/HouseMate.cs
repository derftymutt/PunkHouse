using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PunkHouse.Models
{
    public class HouseMate
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [ForeignKey("HouseId")]
        public int HouseId { get; set; }
        public DateTimeOffset CreationDateTime { get; set; }

        public HouseMate()
        {
            CreationDateTime = DateTimeOffset.Now;
        }
    }
}
