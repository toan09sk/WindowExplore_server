using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WindowExploreServer.Infra;
using WindowExploreServer.Models;

namespace WindowExploreServer.Controllers
{
    public class MangementFileController : ApiController
    {
        private ICustomerRepository _customerRepo;
        public MangementFileController(ICustomerRepository repo)
        {
            _customerRepo = repo;
        }

        [HttpGet]
        public List<Customer> Get()
        {
            return _customerRepo.GetCustomers();
        }
    }
}
