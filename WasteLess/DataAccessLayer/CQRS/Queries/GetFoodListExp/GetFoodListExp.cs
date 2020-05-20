using DataAccessLayer.DataContext;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.CQRS.Queries.GetFoodListExp
{
    public class GetFoodListExp
    {
        long id;
        DateTime leftDate;
        DateTime rightDate;
        public GetFoodListExp(long id, DateTime leftDate, DateTime rightDate)
        {
            this.id = id;
            this.leftDate = leftDate;
            this.rightDate = rightDate;
        }

        public List<FoodItem> query()
        {
            using (var _dcm = new DatabaseConnectionManager())
            {
                IEnumerable<FoodItem> food_item_enum = _dcm.FoodItems.Where(x => (x.User_id == id && x.ExpDate <= rightDate && x.ExpDate >= leftDate && x.ConsDate == null));
                return food_item_enum.ToList();
            }
        }
    }
}
