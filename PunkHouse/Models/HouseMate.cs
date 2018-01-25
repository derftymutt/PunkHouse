using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PunkHouse.Models
{
    public class HouseMate
    {
        public int Id { get; set; }
        [ForeignKey("HouseId")]
        public int HouseId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset DateModified { get; set; }

        public HouseMate()
        {
            DateCreated = DateTimeOffset.Now;
            DateModified = DateTimeOffset.Now;
        }
    }
}
