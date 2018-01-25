using System;
using System.Collections.Generic;

namespace PunkHouse.Models
{
    public class House
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int Zip { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public List<HouseMate> HouseMates { get; set; }
        public List<Expense> Expenses { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset DateModified { get; set; }


        public House()
        {
            DateCreated = DateTimeOffset.Now;
            DateModified = DateTimeOffset.Now;
        }
    }
}
