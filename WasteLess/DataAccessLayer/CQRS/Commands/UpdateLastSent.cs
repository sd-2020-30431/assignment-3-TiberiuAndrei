using DataAccessLayer.DataContext;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Entities;
using System.Linq;

namespace DataAccessLayer.CQRS.Commands
{
    public class UpdateLastSent
    {
        long uid;
        DateTime date;
        public UpdateLastSent(long uid, DateTime date)
        {
            this.uid = uid;
            this.date = date;
        }
        public bool command()
        {
            bool res = false;
            using (var _dcm = new DatabaseConnectionManager())
            {
                var user = _dcm.Users.Find(uid);
                user.LastSent = date;
                _dcm.Users.Update(user);
                _dcm.SaveChanges();
                res = true;
            }
            return res;
        }
 
    }

}
