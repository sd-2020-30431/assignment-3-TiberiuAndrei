using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.CQRS.Queries.GetUserId
{
    public class GetUserIdResponse
    {
        public long response;

        public GetUserIdResponse(long response)
        {
            this.response = response;
        }
    }
}
