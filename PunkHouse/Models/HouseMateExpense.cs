using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PunkHouse.Models
{
    public class HouseMateExpense
    {
        public int HouseMateId { get; set; }
        public int ExpenseId { get; set; }
        public decimal Total { get; set; }
        public int MyProperty { get; set; }
        public bool IsPaid { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
