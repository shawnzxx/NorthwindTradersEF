using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthwindTraders.Data;

namespace NorthwindTraders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly NorthwindDbContext _context;

        public CustomersController(NorthwindDbContext context)
        {
            _context = context;
        }

        // GET api/customers
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _context.Customers.Select(c =>
                new Customer
                {
                    CustomerId = c.CustomerId,
                    CompanyName = c.CompanyName,
                    ContactName = c.ContactName,
                    ContactTitle = c.ContactTitle,
                    Address = c.Address,
                    City = c.City,
                    Country = c.Country
                });
        }
    }
}