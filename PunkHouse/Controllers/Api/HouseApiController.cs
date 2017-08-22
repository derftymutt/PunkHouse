using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PunkHouse.Models;
using PunkHouse.Models.DbContexts;
using PunkHouse.Models.EnumsandConstants;

namespace PunkHouse.Controllers.Api
{
    [Route("api/houses")]
    public class HouseApiController : Controller
    {
        private readonly HouseContext _context;

        public HouseApiController(HouseContext context)
        {
            _context = context;

            if (_context.Houses.Count() == 0)
            {
                _context.Houses.Add(new House()
                {
                    Address1 = "test Address1",
                    Address2 = "test Address2",
                    Name = "Strange View",
                    HouseMates = new List<HouseMate>()
                    {
                        new HouseMate() {FirstName = "Juan", LastName = "Gundino"},
                        new HouseMate() {FirstName = "Sandra", LastName = "Markarian"}
                    },
                    Expenses = new List<Expense>()
                    {
                        new Expense(){Name = "Gas", ExpenseType = ExpenseType.Bill, Total = 345.80m},
                        new Expense(){Name = "Rent", ExpenseType = ExpenseType.Rent, Total = 2300.00m},
                        new Expense(){Name = "Trash bags", ExpenseType = ExpenseType.Supply, Total = 10.00m}
                    }

                });

                _context.SaveChanges();
            }
        }

        [HttpGet]
        public IEnumerable<House> GetAll()
        {
            return _context.Houses.ToList();
        }


    }
}
