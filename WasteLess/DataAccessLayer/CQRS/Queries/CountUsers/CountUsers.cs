using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Entities;
using DataAccessLayer.DataContext;
using System.Linq;
using DataAccessLayer.CQRS.Queries;

namespace DataAccessLayer.CQRS.Queries.CountUsers
{
    public class CountUsers
    {
        string username;
        string password;

        public CountUsers(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public int query()
        {
            int count = 0;
            using (var _dcm = new DatabaseConnectionManager())
            {
                count = _dcm.Users.Count(x => (x.Username == username && x.Password == password));
            }
            return count;
        }

    }

}
