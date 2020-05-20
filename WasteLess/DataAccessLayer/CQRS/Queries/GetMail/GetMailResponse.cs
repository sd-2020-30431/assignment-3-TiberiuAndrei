using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.CQRS.Queries.GetMail
{
    public class GetMailResponse
    {
        public string response;

        public GetMailResponse(string response)
        {
            this.response = response;
        }

    }

}
