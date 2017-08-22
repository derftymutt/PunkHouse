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
        public DateTime DateCreationTime { get; set; }

        public Expense()
        {
        }
    }
}
