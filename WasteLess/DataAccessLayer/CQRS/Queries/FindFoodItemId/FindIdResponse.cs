using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.CQRS.Queries.FindFoodItemId
{
    public class FindIdResponse
    {
        public int response;
        public FindIdResponse(int response)
        {
            this.response = response;
        }

    }

}
