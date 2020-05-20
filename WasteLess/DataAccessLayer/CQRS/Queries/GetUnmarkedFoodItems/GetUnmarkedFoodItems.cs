using DataAccessLayer.DataContext;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.CQRS.Queries.GetUnmarkedFoodItems
{
    public class GetUnmarkedFoodItems
    {
        public List<FoodItem> query()
        {
            using (var _dcm = new DatabaseConnectionManager())
            {
                IEnumerable<FoodItem> food_item_enum = _dcm.FoodItems.Where(x => (x.Marked == false && x.ExpDate <= DateTime.Now));
                return food_item_enum.ToList();
            }

        }
    }
}
