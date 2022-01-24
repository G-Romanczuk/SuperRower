using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperRowerDB
{
    public class CustomerRepository: BaseRepository<Customer>, ICustomerRepository, ICrudRepository<Customer>
    {
        public CustomerRepository(SuperRowerDbContext dbContext) : base(dbContext) { }
        protected override DbSet<Customer> DbSet => _dbContext.Customers;

        public void Update(Customer Customer)
        {
            var foundCustomer = DbSet.Where(x => x.CustomerID == Customer.CustomerID).FirstOrDefault();
            if (foundCustomer == null)
            {
                Create(Customer);
            }
            else
            {
                foundCustomer.StreetAdressCustomer = Customer.StreetAdressCustomer;
                foundCustomer.CityAdressCustomer = Customer.CityAdressCustomer;
                foundCustomer.ApartmentAdressCustomer = Customer.ApartmentAdressCustomer;
                foundCustomer.LastNameCustomer = Customer.LastNameCustomer;
                foundCustomer.NameCustomer = Customer.NameCustomer;
                foundCustomer.KodCustomer = Customer.KodCustomer;
                foundCustomer.TelCustomer = Customer.TelCustomer;
                foundCustomer.BuildingAdressCustomer = Customer.BuildingAdressCustomer;
                SaveChanges();
            }
            
        }
        public void Delete(Customer Customer)
        {
            DbSet.Remove(DbSet.Where(x => x.CustomerID == Customer.CustomerID).FirstOrDefault());
            SaveChanges();
        }

        public void Create(Customer Customer)
        {
            DbSet.Add(Customer);
            SaveChanges();
        }

        public Customer GetById(int id)
        {
            return DbSet.FirstOrDefault(x => x.CustomerID == id);
          
        }

        public Customer GetById(string id)
        {
            throw new NotImplementedException();
        }

    }
}
