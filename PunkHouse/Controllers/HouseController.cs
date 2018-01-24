using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PunkHouse.Models;
using PunkHouse.Data;
using PunkHouse.Models.EnumsandConstants;

namespace PunkHouse.Controllers.Api
{
    [Route("api/houses")]

    public class HouseController : Controller
    {
        private readonly ApplicationDBContext _context;

        public HouseController(ApplicationDBContext context)
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
                        new Expense(){Name = "Rent", ExpenseType = ExpenseType.Rent, Total = 2300.00m}
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
