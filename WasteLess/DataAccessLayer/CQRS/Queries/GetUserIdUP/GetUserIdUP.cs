using DataAccessLayer.DataContext;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.CQRS.Queries.GetUserIdUP
{
    public class GetUserIdUP
    {
        string username;
        string password;
        public GetUserIdUP(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public long query()
        {
            using (var _dcm = new DatabaseConnectionManager())
            {
                User query_user = _dcm.Users.Where(x => (x.Username == username && x.Password == password)).FirstOrDefault();
                return query_user.Id;
            }

        }

    }

}
