using System;
using PunkHouse.Models.EnumsandConstants;
namespace PunkHouse.Models
{
    public class Expense
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int HouseId { get; set; }
        public decimal Total { get; set; }
        public DateTime DueDate { get; set; }
        public ExpenseType ExpenseType { get; set; }
        public bool IsPaid { get; set; }
        public DateTimeOffset CreationDateTime { get; set; }

        public Expense()
        {
            CreationDateTime = DateTimeOffset.Now;
            IsPaid = false;

        }
    }
}
