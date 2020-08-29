using devboost.Domain.Queries.Filters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace devboost.Domain.Handles.Queries.Interfaces
{
    class IClienteBancoHadler
    { 
        Task<QueryUserResult> GetUser(QueryUserFilter queryUserFilter);
    }
}
