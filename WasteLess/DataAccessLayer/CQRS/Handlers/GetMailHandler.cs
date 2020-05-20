using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.CQRS.Queries.GetMail;

namespace DataAccessLayer.CQRS.Handlers
{
    public class GetMailHandler
    {
        public GetMailResponse Handle(GetMail query)
        {
            return new GetMailResponse(query.query());
        }
    
    }

}
