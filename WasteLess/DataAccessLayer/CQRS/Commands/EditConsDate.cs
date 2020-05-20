using DataAccessLayer.DataContext;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Entities;

namespace DataAccessLayer.CQRS.Commands
{
    public class EditConsDate
    {
        long id;
        DateTime? consDate;
        public EditConsDate(long id, DateTime? consDate)
        {
            this.id = id;
            this.consDate = consDate;
        }
        public bool command()
        {
            bool res = false;
            using (var _dcm = new DatabaseConnectionManager())
            {
                var foodItem = _dcm.FoodItems.Find(id);
                foodItem.ConsDate = consDate;
                _dcm.FoodItems.Update(foodItem);
                _dcm.SaveChanges();
                res = true;
            }
            return res;

        }

    }

}
