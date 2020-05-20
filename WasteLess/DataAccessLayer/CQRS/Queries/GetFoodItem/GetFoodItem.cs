using DataAccessLayer.DataContext;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.CQRS.Queries.GetFoodItem
{
    public class GetFoodItem
    {
        long id;
        public GetFoodItem(long id)
        {
            this.id = id;
        }
        public FoodItem query()
        {
            using (var _dcm = new DatabaseConnectionManager())
            {
                FoodItem foodItem = _dcm.FoodItems.Where(x => x.Id == id).FirstOrDefault();
                return foodItem;
            }
        }
    }
}
