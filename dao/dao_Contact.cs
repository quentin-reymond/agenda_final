using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using brouillon_agenda.MusicDB;

namespace Brouillon_Agenda.DAO
{
    public class dao_Contact
    {
        private readonly MydbContext _context;

        public dao_Contact()
        {
            _context = new MydbContext();
        }

        public List<Contact> GetAllContacts()
        {
            return _context.Contacts.ToList();
        }

        public Contact GetContactById(int id)
        {
            return _context.Contacts.FirstOrDefault(c => c.Idcontact == id);
        }

        public void AddContact(Contact contact)
        {
            using (var db = new MydbContext())
            {
                db.Contacts.Add(contact);
                db.SaveChanges();
            }
        }

        public void UpdateContact(Contact contact)
        {
            using (var db = new MydbContext())
            {
                db.Contacts.Update(contact);
                db.SaveChanges();
            }
        }

        public void DeleteContact(int id)
        {
            using (var db = new MydbContext())
            {
                var contact = db.Contacts.FirstOrDefault(c => c.Idcontact == id);
                if (contact != null)
                {
                    db.Contacts.Remove(contact);
                    db.SaveChanges();
                }
            }
        }
    }
}
