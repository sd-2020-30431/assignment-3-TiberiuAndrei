using DataAccessLayer.DataContext;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Entities;

namespace DataAccessLayer.CQRS.Commands
{
    public class RemoveFoodItem
    {
        long id;
        public RemoveFoodItem(long id)
        {
            this.id = id;
        }
        public bool command()
        {
            bool res = false;
            using (var _dcm = new DatabaseConnectionManager())
            {
                var foodItem = _dcm.FoodItems.Find(id);
                _dcm.FoodItems.Remove(foodItem);
                _dcm.SaveChanges();
                res = true;
            }
            return res;
        }

    }

}
