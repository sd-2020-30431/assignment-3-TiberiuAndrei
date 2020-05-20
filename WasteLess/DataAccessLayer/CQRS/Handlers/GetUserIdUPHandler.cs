using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.CQRS.Queries.GetUserIdUP;
using DataAccessLayer.Entities;

namespace DataAccessLayer.CQRS.Handlers
{
    public class GetUserIdUPHandler
    {
        public GetUserIdUPResponse Handle(GetUserIdUP query)
        {
            return new GetUserIdUPResponse(query.query());
        }

    }

}
