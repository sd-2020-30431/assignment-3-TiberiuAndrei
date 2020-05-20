using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.CQRS.Queries.GetFoodItem;

namespace DataAccessLayer.CQRS.Handlers
{
    public class GetFoodItemHandler
    {
        public GetFoodItemResponse Handle(GetFoodItem query)
        {
            return new GetFoodItemResponse(query.query());
        }

    }
}
