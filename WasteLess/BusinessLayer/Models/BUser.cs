using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.Managers;
using DataAccessLayer.Entities;
using DataAccessLayer.CQRS.Queries.GetUnmarkedFoodItems;
using DataAccessLayer.CQRS;
using DataAccessLayer.CQRS.Commands;

namespace BusinessLayer.Models
{
    public class BUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }

        public void Update(string umail)
        {
            Mediator m = new Mediator();
            GetUnmarkedFoodItems getUnmarkedFoodItems = new GetUnmarkedFoodItems();
            List<FoodItem> foodList = m.getUnmarkedFoodItemsHandler.Handle(getUnmarkedFoodItems).response;

            if (foodList.Count > 0)
            {
                NotificationManager nm = new NotificationManager();
                string message = nm.ComposeDueNotificationMessage(foodList);
                MailManager mailManager = new MailManager();
                BMailBot bMailBot = mailManager.getBMailBot();
                mailManager.sendMail(bMailBot.Username, bMailBot.Password, umail, "New Items Expired", message);
                UpdateMarked updateMarked = new UpdateMarked(foodList);
                m.updateMarkedHandler.Handle(updateMarked);
                //fia.UpdateMarked(foodList);
            }

        }

    }

}
