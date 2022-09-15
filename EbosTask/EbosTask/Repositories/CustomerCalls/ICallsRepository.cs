using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EbosTask.Models;

namespace EbosTask.Repositories
{
    public interface ICallsRepository
    {
        List<CallsModel> GetCalls();
        int AddCall(CallsModel cust);
        bool UpdateCalls(CallsModel calls);
        bool DeleteCall(int id);
        List<CustNumbers> GetCustNumbers();
    }
}

