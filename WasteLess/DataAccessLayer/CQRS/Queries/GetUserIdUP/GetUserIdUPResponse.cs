using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.CQRS.Queries.GetUserIdUP
{
    public class GetUserIdUPResponse
    {
        public long response;

        public GetUserIdUPResponse(long response)
        {
            this.response = response;
        }
    }
}
