using EventManagingSystem.DAL;
using EventManagingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagingSystem.BLL
{
    public class EventManager
    {
        DataContextModel dc = new DataContextModel();

        public List<Event> GetEvents()
        {
            return dc.Event.ToList();

        }
        public Event GetEvent()
        {
            var a = dc.Event.ToList();
            List<int> ids = new List<int>();
            foreach (var item in a)
            {
                ids.Add(item.EventID);
            }
            Random rnd = new Random();
            int Random = rnd.Next(a.Count);
            int rndnumber = ids[Random];
            return dc.Event.FirstOrDefault(e => e.EventID == rndnumber);
        }
        public void AddEvent(Event events)
        {
            dc.Event.Add(events);
            dc.SaveChanges();
        }
    }
}
