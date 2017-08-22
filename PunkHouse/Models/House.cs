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
        public List<HouseMate> HouseMates { get; set; }
        public List<Expense> Expenses { get; set; }
        public DateTimeOffset CreationDateTime { get; set; }


        public House()
        {
            CreationDateTime = DateTimeOffset.Now;
        }
    }
}
