using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Entities;
using BusinessLayer.Models;
using System.Text.RegularExpressions;
using DataAccessLayer.CQRS;
using DataAccessLayer.CQRS.Queries.GetFoodListExp;
using DataAccessLayer.CQRS.Queries.GetFoodItem;
using DataAccessLayer.CQRS.Queries.FindLatestFood;
using DataAccessLayer.CQRS.Commands;
using DataAccessLayer.CQRS.Queries.FindFoodItemId;
using DataAccessLayer.CQRS.Queries.GetFoodList;

namespace BusinessLayer.Managers
{
    public class FoodManager
    {
        public List<BFoodItem> getFoodList(long uid)
        {
            Mediator m = new Mediator();
            GetFoodList getFoodList = new GetFoodList(uid);
            List<FoodItem> food_list = m.getFoodListHandler.Handle(getFoodList).response;
            List<BFoodItem> bfood_list = new List<BFoodItem>();
            foreach (FoodItem fi in food_list)
            {
                bfood_list.Add(convert_to_bfi(fi));
            }
            return bfood_list;
        }

        //returns the food items for the user identified by uid, that will expire between leftTime and rightTime
        public List<BFoodItem> getFoodListExp(long uid, DateTime leftTime, DateTime rightTime)
        {
            Mediator m = new Mediator();
            GetFoodListExp getFoodListExp = new GetFoodListExp(uid, leftTime, rightTime);
            List<FoodItem> food_list = m.getFoodListExpHandler.Handle(getFoodListExp).response;

            List<BFoodItem> bfood_list = new List<BFoodItem>();
            foreach (FoodItem fi in food_list)
            {
                bfood_list.Add(convert_to_bfi(fi));
            }
            return bfood_list;
        }

        //create clone model of FoodItem so I don not skip a layer by using database models
        //directly in views and controllers
        private BFoodItem convert_to_bfi(FoodItem fi)
        {
            return new BFoodItem
            {
                Id = fi.Id,
                Name = fi.Name,
                Quantity = fi.Quantity,
                Calories = fi.Calories,
                PurchaseDate = fi.PurchaseDate,
                ExpDate = fi.ExpDate,
                ConsDate = fi.ConsDate,
                Marked = fi.Marked,
                User_id = fi.User_id
            };
        }

        private FoodItem convert_to_fi(BFoodItem bfi)
        {
            return new FoodItem
            {
                Id = bfi.Id,
                Name = bfi.Name,
                Quantity = bfi.Quantity,
                Calories = bfi.Calories,
                PurchaseDate = bfi.PurchaseDate,
                ExpDate = bfi.ExpDate,
                ConsDate = bfi.ConsDate,
                Marked = bfi.Marked,
                User_id = bfi.User_id
            };
        }

        //adds a food item in the database, respecting the validation rules
        public int addFoodItem(BFoodItem bFoodItem)
        {
            Mediator m = new Mediator();
            FindLatestFood findLatestFood = new FindLatestFood();
            FoodItem latestFood = m.findLatestFoodHandler.Handle(findLatestFood).response;

            if (!(latestFood.Name.Equals(bFoodItem.Name) && latestFood.PurchaseDate.Equals(bFoodItem.PurchaseDate) && latestFood.ExpDate.Equals(bFoodItem.ExpDate) && latestFood.Quantity.Equals(bFoodItem.Quantity)))
            {
                //Invalid Purchase date
                if(bFoodItem.PurchaseDate.Equals(DateTime.MinValue))
                {
                    return 1;
                }

                //Invalid Expiration date
                if (bFoodItem.ExpDate.Equals(DateTime.MinValue))
                {
                    return 2;
                }

                //Invalid Consumption date
                if (bFoodItem.ConsDate.Equals(DateTime.MinValue))
                {
                    return 3;
                }

                //Name can contain only english letters
                if (!Regex.IsMatch(bFoodItem.Name, @"^[a-zA-z]+$"))
                {
                    return 4;
                }

                //Qunatity limits
                if(bFoodItem.Quantity < 0)
                {
                    return 5;
                }

                if (bFoodItem.Quantity > 1000)
                {
                    return 6;
                }

                //Calories limits
                if (bFoodItem.Calories < 0)
                {
                    return 7;
                }

                if (bFoodItem.Calories > 1000000)
                {
                    return 8;
                }

                if (bFoodItem.ConsDate >DateTime.Now)
                {
                    return 9;
                }

                if (bFoodItem.PurchaseDate > DateTime.Now)
                {
                    return 10;
                }

                //Successfully inserted
                AddFoodItem addFoodItem = new AddFoodItem(convert_to_fi(bFoodItem));
                m.addFoodItemHandler.Handle(addFoodItem);

                //fia.addFoodItem(convert_to_fi(bFoodItem));
                return 0;
            }
            return 11;
        }

        //removes the food item identifed by bfid
        public bool removeFoodItem(long bfid)
        {
            Mediator m = new Mediator();

            FindId findId = new FindId(bfid);
            if (m.findIdHandler.Handle(findId).response != 0)
            {
                RemoveFoodItem removeFoodItem = new RemoveFoodItem(bfid);
                return m.removeFoodItemHandler.Handle(removeFoodItem);
            }
            return false;
        }

        //returns the food item identifed by bfid
        public BFoodItem getBFoodItem(long bfid)
        {
            //FoodItemAccess fia = new FoodItemAccess();
            Mediator m = new Mediator();
            GetFoodItem getFoodItem = new GetFoodItem(bfid);
            return convert_to_bfi(m.getFoodItemHandler.Handle(getFoodItem).response);
        }

        //allows the user to set and update the consumption date. First checks if the date is valod
        //and if the item exists
        public int editConsDate(long bfid, DateTime? consDate)
        {
            Mediator m = new Mediator();
            FindId findId = new FindId(bfid);
            if (m.findIdHandler.Handle(findId).response != 0)
            {
                if(consDate == null)
                {
                    EditConsDate editConsDate = new EditConsDate(bfid, consDate);
                    m.editConsDateHandler.Handle(editConsDate);
                    //fia.editConsDate(bfid, consDate);
                    return 0;
                }

                BFoodItem bFoodItem = getBFoodItem(bfid);
                if(bFoodItem.PurchaseDate > consDate)
                {
                    return 1;
                }
                EditConsDate editConsDate1 = new EditConsDate(bfid, consDate);
                m.editConsDateHandler.Handle(editConsDate1);
                //fia.editConsDate(bfid, consDate);
                return 0;
            }
            return 2;
        }

    }
}
