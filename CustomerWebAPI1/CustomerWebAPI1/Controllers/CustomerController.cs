using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerWebAPI.services;
using Microsoft.AspNetCore.Mvc;
using RestaurantAPI.Models;

namespace RestaurantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet]
        [Route("GetCustomers/")]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        {
            return (await _customerService.GetCustomers()).ToList();
        }
    
}
}
