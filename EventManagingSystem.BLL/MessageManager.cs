using EventManagingSystem.DAL;
using EventManagingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagingSystem.BLL
{
   public class MessageManager
    {
        DataContextModel dc = new DataContextModel();
        
        public List<Message> Inbox(int id)
        {
            return dc.Message.Where(m => m.MessageTo == id).ToList();
        }
        public List<Message> Outbox(int id)
        {
            return dc.Message.Where(m => m.MessageFrom == id).ToList();
        }
        public void SendMessage(Message message)
        {
            dc.Message.Add(message);
            dc.SaveChanges();
        }
        public Message MessageDetail(int id)
        {
            return dc.Message.FirstOrDefault(m => m.MessageTo == id);
        }
        public Message ObMessageDetail(int id)
        {
            return dc.Message.FirstOrDefault(m => m.MessageFrom == id);
        }
    }
}
