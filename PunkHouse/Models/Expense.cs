using System;
using PunkHouse.Models.EnumsandConstants;
namespace PunkHouse.Models
{
    public class Expense
    {

        public int Id { get; set; }
        public int HouseId { get; set; }
        public int CreatorId { get; set; }
        public string Name { get; set; }
        public ExpenseType ExpenseType { get; set; }
        public string Description { get; set; }
        public decimal Total { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsPaid { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset DateModified { get; set; }

        public Expense()
        {
            DateCreated = DateTimeOffset.Now;
            DateModified = DateTimeOffset.Now;
            IsPaid = false;

        }
    }
}
