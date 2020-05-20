using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.CQRS.Queries.CountUsers
{
    public class CountUsersResponse
    {
        public int response;
        public CountUsersResponse(int response)
        {
            this.response = response;
        }

    }

}
