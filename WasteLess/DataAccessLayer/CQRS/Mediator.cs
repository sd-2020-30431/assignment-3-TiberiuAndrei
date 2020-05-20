using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.CQRS.Handlers;

namespace DataAccessLayer.CQRS
{
    public class Mediator
    {
        public AddFoodItemHandler addFoodItemHandler;
        public CountUsersHandler countUsersHandler;
        public EditConsDateHandler editConsDateHandler;
        public FindIdHandler findIdHandler;
        public FindLatestFoodHandler findLatestFoodHandler;
        public GetCharOrgListHandler getCharOrgListHandler;
        public GetFoodItemHandler getFoodItemHandler;
        public GetFoodListExpHandler getFoodListExpHandler;
        public GetLastSentHandler getLastSentHandler;
        public GetMailBotHandler getMailBotHandler;
        public GetMailHandler getMailHandler;
        public GetUnmarkedFoodItemsHandler getUnmarkedFoodItemsHandler;
        public GetUserIdHandler getUserIdHandler;
        public GetUserIdUPHandler getUserIdUPHandler;
        public RemoveFoodItemHandler removeFoodItemHandler;
        public UpdateLastSentHandler updateLastSentHandler;
        public UpdateMarkedHandler updateMarkedHandler;
        public GetFoodListHandler getFoodListHandler;
        public Mediator()
        {
            this.addFoodItemHandler = new AddFoodItemHandler();
            this.countUsersHandler = new CountUsersHandler();
            this.editConsDateHandler = new EditConsDateHandler();
            this.findIdHandler = new FindIdHandler();
            this.findLatestFoodHandler = new FindLatestFoodHandler();
            this.getCharOrgListHandler = new GetCharOrgListHandler();
            this.getFoodItemHandler = new GetFoodItemHandler();
            this.getFoodListExpHandler = new GetFoodListExpHandler();
            this.getLastSentHandler = new GetLastSentHandler();
             this.getMailBotHandler = new GetMailBotHandler();
            this.getMailHandler = new GetMailHandler();
            this.getUnmarkedFoodItemsHandler = new GetUnmarkedFoodItemsHandler();
            this.getUserIdHandler = new GetUserIdHandler();
            this.getUserIdUPHandler = new GetUserIdUPHandler();
            this.removeFoodItemHandler = new RemoveFoodItemHandler();
            this.updateLastSentHandler = new UpdateLastSentHandler();
            this.updateMarkedHandler = new UpdateMarkedHandler();
            this.getFoodListHandler = new GetFoodListHandler();
        }
    }
}
