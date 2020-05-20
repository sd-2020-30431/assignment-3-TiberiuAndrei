using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.CQRS.Queries.GetUserId;
using DataAccessLayer.Entities;

namespace DataAccessLayer.CQRS.Handlers
{
    public class GetUserIdHandler
    {
        public GetUserIdResponse Handle(GetUserId query)
        {
            return new GetUserIdResponse(query.query());
        }

    }

}
