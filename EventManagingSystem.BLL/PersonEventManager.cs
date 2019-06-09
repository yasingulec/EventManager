using EventManagingSystem.DAL;
using EventManagingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagingSystem.BLL
{
 public class PersonEventManager
    {
        DataContextModel dc = new DataContextModel();
        public void Join(EventPerson eventPerson)
        {
            dc.EventPerson.Add(eventPerson); 
            dc.SaveChanges();
        }
    }
}
