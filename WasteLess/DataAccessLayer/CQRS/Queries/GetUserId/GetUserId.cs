using DataAccessLayer.DataContext;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.CQRS.Queries.GetUserId
{
    public class GetUserId
    {
        string username;
        public GetUserId(string username)
        {
            this.username = username;
        }
        public long query()
        {
            using (var _dcm = new DatabaseConnectionManager())
            {
                User query_user = _dcm.Users.Where(x => x.Username == username).FirstOrDefault();
                return query_user.Id;
            }

        }

    }

}
