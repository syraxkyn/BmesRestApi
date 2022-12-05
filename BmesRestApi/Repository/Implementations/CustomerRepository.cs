using BmesRestApi.Database;
using BmesRestApi.Models.Customer;
using BmesRestApi.Models.Shared;
using Microsoft.EntityFrameworkCore;

namespace BmesRestApi.Repository.Implementations
{
    public class CustomerRepository:ICustomerRepository
    {
        private BmesDbContext _context;

        public CustomerRepository(BmesDbContext context)
        {
            _context = context;
        }

        public Customer FindCustomerById(long id)
        {
            var customer = _context.Customers.Find(id);
            return customer;
        }
        public int GetLastCustomerId()
        {
            Customer customer = _context.Customers.FromSqlRaw("Select * from Customers where id=(select max(id) from Customers)").ToList().FirstOrDefault();
            return (int)customer.Id;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            var customers = _context.Customers;
            return customers;
        }
        public void SaveCustomer(Customer customer)
        {
            _context.Customers.FromSqlRaw($"p_customers_insert {customer.PersonId}").ToList().FirstOrDefault();

            //_context.People.FromSqlRaw($"p_customers_insert {customer.PersonId}").ToList().FirstOrDefault();
            //_context.Customers.Add(customer);
            //_context.SaveChanges();
        }
        public void UpdateCustomer(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
        }

        public void DeleteCustomer(Customer customer)
        {
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }
    }
}
