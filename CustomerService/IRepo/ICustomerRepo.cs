using CustomerService.Entity;

namespace CustomerService.IRepo
{
    public interface ICustomerRepo
    {
        Customer AddUser(Customer customer);
        List<Customer> GetCustomers();

    }
}
