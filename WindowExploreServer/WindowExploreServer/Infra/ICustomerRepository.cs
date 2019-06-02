using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowExploreServer.Models;

namespace WindowExploreServer.Infra
{
    public interface ICustomerRepository
    {
        List<Customer> GetCustomers();
    }
}
