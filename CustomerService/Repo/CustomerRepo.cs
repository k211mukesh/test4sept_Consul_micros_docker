using System.Security.AccessControl;
using CustomerService.Context;
using CustomerService.Entity;
using CustomerService.IRepo;

namespace CustomerService.Repo
{
    public class CustomerRepo : ICustomerRepo
    {
        private CustDbContext _context;
        public CustomerRepo(CustDbContext context)
        {
            _context = context;
        }
        public Customer AddUser(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return customer;
        }
        public List<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }
    }
}
