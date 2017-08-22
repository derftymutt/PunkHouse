using System;
namespace PunkHouse.Models
{
    public class HouseMate
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
       // [ForeignKey]
        public int HouseId { get; set; }
        public DateTime DateCreationTime { get; set; }

        public HouseMate()
        {
            DateCreationTime = new DateTime();
        }
    }
}
