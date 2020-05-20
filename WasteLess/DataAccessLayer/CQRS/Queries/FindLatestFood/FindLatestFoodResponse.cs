using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.CQRS.Queries.FindLatestFood
{
    public class FindLatestFoodResponse
    {
        public FoodItem response;
        public FindLatestFoodResponse(FoodItem response)
        {
            this.response = response;
        }
    }
}
