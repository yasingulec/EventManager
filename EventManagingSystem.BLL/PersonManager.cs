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
        public Person GetPerson(int id)
        {
            return dc.Person.FirstOrDefault(p => p.PersonID == id);
        }
        public void UpdateProfile(Person _person)
        {
            Person person = dc.Person.FirstOrDefault(p => p.PersonID == _person.PersonID);
            person.FirstName = _person.FirstName;
            person.DateOfBirth = _person.DateOfBirth;
            person.UserName = _person.UserName;
            person.Password = _person.Password;
            dc.SaveChanges();
        }
    }
}
