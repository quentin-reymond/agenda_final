using System;
using System.Collections.Generic;
using System.Linq;
using brouillon_agenda.MusicDB;

namespace brouillon_agenda.DAO
{
    public class dao_EventTask
    {
        private readonly MydbContext _context;

        public dao_EventTask()
        {
            _context = new MydbContext();
        }

        // Get all EventTasks
        public List<EventTask> GetAllEventTasks()
        {
            return _context.EventTasks.ToList();
        }

        // Get EventTask by ID
        public EventTask GetEventTaskById(int id)
        {
            return _context.EventTasks.FirstOrDefault(et => et.Idevent == id);
        }

        // Add a new EventTask
        public void AddEventTask(EventTask eventTask)
        {
            using (var db = new MydbContext())
            {
                db.EventTasks.Add(eventTask);
                db.SaveChanges();
            }
        }

        // Update an existing EventTask
        public void UpdateEventTask(EventTask eventTask)
        {
            using (var db = new MydbContext())
            {
                db.EventTasks.Update(eventTask);
                db.SaveChanges();
            }
        }

        // Delete an EventTask by ID
        public void DeleteEventTask(int id)
        {
            using (var db = new MydbContext())
            {
                var eventTask = db.EventTasks.FirstOrDefault(et => et.Idevent == id);
                if (eventTask != null)
                {
                    db.EventTasks.Remove(eventTask);
                    db.SaveChanges();
                }
            }
        }
    }
}