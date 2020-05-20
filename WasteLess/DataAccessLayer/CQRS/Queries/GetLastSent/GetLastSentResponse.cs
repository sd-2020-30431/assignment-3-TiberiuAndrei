using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.CQRS.Queries.GetLastSent
{
    public class GetLastSentResponse
    {
        public DateTime response;

        public GetLastSentResponse(DateTime response)
        {
            this.response = response;
        }

    }

}
