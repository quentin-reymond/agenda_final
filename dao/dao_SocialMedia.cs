using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using brouillon_agenda.MusicDB;

namespace Brouillon_Agenda.DAO
{
    public class dao_SocialMedia
    {
        private readonly MydbContext _context;

        public dao_SocialMedia()
        {
            _context = new MydbContext();
        }

        public List<Socialmedium> GetAllSocialMedia()
        {
            return _context.Socialmedia.ToList();
        }

        public Socialmedium GetSocialMediaById(int id)
        {
            return _context.Socialmedia.FirstOrDefault(sm => sm.Idsocialmedia == id);
        }

        public void AddSocialMedia(Socialmedium socialMedia)
        {
            using (var db = new MydbContext())
            {
                db.Socialmedia.Add(socialMedia);
                db.SaveChanges();
            }
        }

        public void UpdateSocialMedia(Socialmedium socialMedia)
        {
            using (var db = new MydbContext())
            {
                db.Socialmedia.Update(socialMedia);
                db.SaveChanges();
            }
        }

        public void DeleteSocialMedia(int id)
        {
            using (var db = new MydbContext())
            {
                var socialMedia = db.Socialmedia.FirstOrDefault(sm => sm.Idsocialmedia == id);
                if (socialMedia != null)
                {
                    db.Socialmedia.Remove(socialMedia);
                    db.SaveChanges();
                }
            }
        }
    }
}
