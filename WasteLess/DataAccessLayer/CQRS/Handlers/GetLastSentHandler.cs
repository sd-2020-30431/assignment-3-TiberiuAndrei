using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.CQRS.Queries.GetLastSent;

namespace DataAccessLayer.CQRS.Handlers
{
    public class GetLastSentHandler
    {
        public GetLastSentResponse Handle(GetLastSent query)
        {
            return new GetLastSentResponse(query.query());
        }

    }

}
