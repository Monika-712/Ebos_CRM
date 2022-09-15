using EbosTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EbosTask.Repositories
{
    public interface ICustomerRepository
    {
        int CreateCustomer(CustomersModel cust);
        List<CustomersModel> getCustomer();
        bool DeleteCustomer(Guid id);
        bool UpdateCustomer(CustomersModel customer);
        //int EmpLoginCheck(Login user);

    }
}