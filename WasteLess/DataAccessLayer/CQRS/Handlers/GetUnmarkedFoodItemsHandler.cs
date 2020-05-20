using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.CQRS.Queries.GetUnmarkedFoodItems;
using DataAccessLayer.Entities;

namespace DataAccessLayer.CQRS.Handlers
{
    public class GetUnmarkedFoodItemsHandler
    {
        public GetUnmarkedFoodItemsResponse Handle(GetUnmarkedFoodItems query)
        {
            return new GetUnmarkedFoodItemsResponse(query.query());
        }

    }

}
