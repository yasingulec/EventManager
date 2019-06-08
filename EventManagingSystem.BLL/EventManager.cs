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
        public Event GetEvent(int id)
        {
           return dc.Event.FirstOrDefault(x => x.EventID == id);           
        }
        public void AddEvent(Event events)
        {
            dc.Event.Add(events);
            dc.SaveChanges();
        }
        public void DeleteEvent(int id)
        {
            Event events = dc.Event.FirstOrDefault(e =>e.EventID==id);
            dc.Event.Remove(events);
            dc.SaveChanges();
        }
        public List<Event> GetEvents(int id)
        {
            return dc.Event.Where(e => e.CategoryID == id).ToList();
        }
    }
}
