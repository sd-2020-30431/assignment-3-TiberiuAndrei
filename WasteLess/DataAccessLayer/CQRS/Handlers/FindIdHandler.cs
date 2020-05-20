using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.CQRS.Queries;
using DataAccessLayer.CQRS.Queries.FindFoodItemId;

namespace DataAccessLayer.CQRS.Handlers
{
    public class FindIdHandler
    {
        public FindIdResponse Handle(FindId query)
        {
            return new FindIdResponse(query.query());
        }
    
    }

}
