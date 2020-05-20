using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Entities;
using BusinessLayer.Models;
using DataAccessLayer.CQRS;
using DataAccessLayer.CQRS.Queries;
using DataAccessLayer.CQRS.Queries.GetCharOrgList;

namespace BusinessLayer.Managers
{
    public class CharOrgManager
    {
        //create clone model of CharOrg so I don not skip a layer by using database models
        //directly in views and controllers
        public BCharOrg convertToBCharOrg(CharOrg charOrg)
        {
            return new BCharOrg
            {
                Id = charOrg.Id,
                Address = charOrg.Address,
                Phone = charOrg.Phone
            };

        }

        //extracts the charity organisations from the database and converts to the clone model
        public List<BCharOrg> getBCharOrgList()
        {
            Mediator m = new Mediator();

            GetCharOrgList getCharOrgList = new GetCharOrgList();

            List<CharOrg> charOrgList = m.getCharOrgListHandler.Handle(getCharOrgList).response;
            
            List<BCharOrg> bCharOrgList = new List<BCharOrg>();
            
            foreach (CharOrg c in charOrgList)
            {
                bCharOrgList.Add(convertToBCharOrg(c));
            }
            return bCharOrgList;

        }

    }

}
