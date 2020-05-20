using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Entities;

namespace DataAccessLayer.CQRS.Queries.GetFoodList
{
    public class GetFoodListResponse
    {
        public List<FoodItem> response;

        public GetFoodListResponse(List<FoodItem> response)
        {
            this.response = response;
        }

    }

}
