using CustomerService.Entity;
using CustomerService.IRepo;

namespace CustomerService.BAL
{
    public class CustomerIndexView
    {
        private ICustomerRepo _Repo;
        public CustomerIndexView(ICustomerRepo Repo)
        {
            _Repo = Repo;
        }
        public Customer AddUser(Customer customer)
        {
            return _Repo.AddUser(customer);
        }

        public List<Customer> GetCustomers()
        {
            return _Repo.GetCustomers();
        }
    }
}
