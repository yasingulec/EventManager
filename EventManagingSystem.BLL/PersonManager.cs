using EventManagingSystem.Entities;
using EventManagingSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagingSystem.BLL
{
   public class PersonManager
    {
        DataContextModel dc = new DataContextModel();
        public void Register(Person person)
        {
            
            dc.Person.Add(person);
            dc.SaveChanges();
        }

        public Person GetPerson(Person person)
        {
            return dc.Person.FirstOrDefault(p=>p.UserName==person.UserName && p.Password==person.Password);
        }
    }
}
