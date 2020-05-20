using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer.DataContext;
using DataAccessLayer.Entities;

namespace DataAccessLayer.CQRS.Queries.GetFoodList
{
    public class GetFoodList
    {
        long id;
        public GetFoodList(long id)
        {
            this.id = id;
        }
        public List<FoodItem> query()
        {
            using (var _dcm = new DatabaseConnectionManager())
            {
                IEnumerable<FoodItem> food_item_enum = (from _food_item in _dcm.FoodItems where _food_item.User_id == id select _food_item).AsEnumerable();
                return food_item_enum.ToList();
            }
        }

    }

}
