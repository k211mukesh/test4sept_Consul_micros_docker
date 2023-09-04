using CustomerService.BAL;
using CustomerService.Entity;
using Microsoft.AspNetCore.Mvc;

namespace CustomerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private CustomerIndexView _IView;
        public CustomerController(CustomerIndexView IView)
        {
            _IView = IView;
        }

        [HttpGet]
        public List<Customer> Get()
        {
            return _IView.GetCustomers().ToList();
        }

        [HttpPost]
        public ActionResult Create(Customer createobj)
        {
            return Ok(_IView.AddUser(createobj));   

        }

    }
}
