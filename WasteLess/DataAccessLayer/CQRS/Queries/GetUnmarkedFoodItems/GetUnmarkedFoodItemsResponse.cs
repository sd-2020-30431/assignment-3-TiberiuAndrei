using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.CQRS.Queries.GetUnmarkedFoodItems
{
    public class GetUnmarkedFoodItemsResponse
    {
        public List<FoodItem> response;

        public GetUnmarkedFoodItemsResponse(List<FoodItem> response)
        {
            this.response = response;
        }

    }

}
