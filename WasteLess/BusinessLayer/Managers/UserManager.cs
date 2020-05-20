using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.Models;
using DataAccessLayer.CQRS;
using DataAccessLayer.CQRS.Queries;
using DataAccessLayer.CQRS.Queries.CountUsers;
using DataAccessLayer.CQRS.Queries.GetUserIdUP;
using DataAccessLayer.CQRS.Queries.GetUserId;
using DataAccessLayer.CQRS.Queries.GetMail;
using DataAccessLayer.CQRS.Queries.GetLastSent;
using DataAccessLayer.CQRS.Commands;

namespace BusinessLayer.Managers
{
    public class UserManager
    {
        //cheks if the combination of user and password exists in the database
        public bool validate_user(BUser buser)
        {
            Mediator m = new Mediator();
            CountUsers countUsers = new CountUsers(buser.Username, buser.Password);
            if(m.countUsersHandler.Handle(countUsers).response == 1)
            {
                return true;
            }
            
            return false;

        }

        public long get_id(BUser buser)
        {
            Mediator m = new Mediator();
            GetUserIdUP getUserIdUP = new GetUserIdUP(buser.Username, buser.Password);
            return m.getUserIdUPHandler.Handle(getUserIdUP).response;

        }

        public long getId(string user)
        {
            Mediator m = new Mediator();
            GetUserId getUserId = new GetUserId(user);
            return m.getUserIdHandler.Handle(getUserId).response;

        }

        public string getMail(string username)
        {
            Mediator m = new Mediator();
            GetMail getMail = new GetMail(username);
            return m.getMailHandler.Handle(getMail).response;

        }

        //gets the last date when a mail has been sent to a user
        //used to avoid spamming
        public DateTime getLastSent(string username)
        {
            Mediator m = new Mediator();
            GetLastSent getLastSent = new GetLastSent(username);
            return m.getLastSentHandler.Handle(getLastSent).response;

        }

        public bool updateLastSent(long uid)
        {
            Mediator m = new Mediator();
            UpdateLastSent updateLastSent = new UpdateLastSent(uid, DateTime.Now);
            return m.updateLastSentHandler.Handle(updateLastSent);

        }

    }
}
