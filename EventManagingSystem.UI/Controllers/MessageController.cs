using EventManagingSystem.BLL;
using EventManagingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventManagingSystem.UI.Controllers
{
    public class MessageController : Controller
    {
        MessageManager messageManager = new MessageManager();
        // GET: Message
        public ActionResult Inbox()
        {
            Person person =(Person) Session["Login"];
            List<Message> messages = messageManager.Inbox(person.PersonID);
            return View(messages);
        }
        public ActionResult Outbox()
        {
            Person person = (Person)Session["Login"];
            List<Message> messages = messageManager.Outbox(person.PersonID);
            return View(messages);
        }
        [HttpGet]
        public ActionResult SendMessage(int id)
        {
            Session["ID"] = id;
            return View();
        }
        [HttpPost]
        public ActionResult SendMessage(Message message)
        {
            Person person = (Person)Session["Login"];
            message.MessageFrom = person.PersonID;
            message.MessageTo =(int) Session["ID"];
            message.MessageDate = DateTime.Now;
            messageManager.SendMessage(message);
            return View();
        }
        public ActionResult MessageDetail(int id)
        {         
            Message message = messageManager.MessageDetail(id);
            Message message2 = messageManager.ObMessageDetail(id);
            if (message !=null)
            {
                return View(message);
            }
            return View(message2);
        }
    }
}