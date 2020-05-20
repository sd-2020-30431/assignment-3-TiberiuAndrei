using DataAccessLayer.CQRS.Queries.GetCharOrgList;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.CQRS.Handlers
{
    public class GetCharOrgListHandler
    {
        public GetCharOrgListResponse Handle(GetCharOrgList query)
        {
            return new GetCharOrgListResponse(query.query());
        }

    }

}
