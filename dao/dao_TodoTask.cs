using System;
using System.Collections.Generic;
using System.Linq;
using brouillon_agenda.MusicDB;

namespace brouillon_agenda.DAO
{
    public class dao_TodoTask
    {
        private readonly MydbContext _context;

        public dao_TodoTask()
        {
            _context = new MydbContext();
        }

        // Get all TodoTasks
        public List<Todotask> GetAllTodoTasks()
        {
            return _context.Todotasks.ToList();
        }

        // Get TodoTask by ID
        public Todotask GetTodoTaskById(int id)
        {
            return _context.Todotasks.FirstOrDefault(tt => tt.Idtask == id);
        }

        // Add a new TodoTask
        public void AddTodoTask(Todotask todoTask)
        {
            using (var db = new MydbContext())
            {
                db.Todotasks.Add(todoTask);
                db.SaveChanges();
            }
        }

        // Update an existing TodoTask
        public void UpdateTodoTask(Todotask todoTask)
        {
            using (var db = new MydbContext())
            {
                db.Todotasks.Update(todoTask);
                db.SaveChanges();
            }
        }

        // Delete a TodoTask by ID
        public void DeleteTodoTask(int id)
        {
            using (var db = new MydbContext())
            {
                var todoTask = db.Todotasks.FirstOrDefault(tt => tt.Idtask == id);
                if (todoTask != null)
                {
                    db.Todotasks.Remove(todoTask);
                    db.SaveChanges();
                }
            }
        }
    }
}