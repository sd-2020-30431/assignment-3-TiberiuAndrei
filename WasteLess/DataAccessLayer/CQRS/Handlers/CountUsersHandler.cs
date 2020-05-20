using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.CQRS.Queries;
using DataAccessLayer.CQRS.Queries.CountUsers;

namespace DataAccessLayer.CQRS.Handlers
{
    public class CountUsersHandler
    {
        public CountUsersResponse Handle(CountUsers query)
        {
            return new CountUsersResponse(query.query());
        }

    }

}
