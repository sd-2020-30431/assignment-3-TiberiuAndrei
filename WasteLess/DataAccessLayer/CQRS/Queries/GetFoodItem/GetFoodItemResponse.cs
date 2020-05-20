using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.CQRS.Queries.GetFoodItem
{
    public class GetFoodItemResponse
    {
        public FoodItem response;

        public GetFoodItemResponse(FoodItem response)
        {
            this.response = response;
        }

    }

}
