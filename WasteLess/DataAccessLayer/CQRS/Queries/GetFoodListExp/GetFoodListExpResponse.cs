using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.CQRS.Queries.GetFoodListExp
{
    public class GetFoodListExpResponse
    {
        public List<FoodItem> response;

        public GetFoodListExpResponse(List<FoodItem> response)
        {
            this.response = response;
        }

    }
}
