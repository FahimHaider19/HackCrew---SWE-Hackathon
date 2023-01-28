using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CommentRepo : IRepo<Comment>
    {
        private PorteBoshboEntities db = new PorteBoshboEntities();

        public bool Add(Comment obj)
        {
            db.Comments.Add(obj);
            return db.SaveChanges() > 0;
        }

        public Comment Get(int id)
        {
            return db.Comments.Find(id);
        }

        public List<Comment> GetAll()
        {
            return db.Comments.ToList();
        }

        public bool Remove(int id)
        {
            db.Comments.Remove(Get(id));
            return db.SaveChanges() > 0;
        }

        public bool Update(Comment obj)
        {
            db.Entry(Get(obj.CommentId)).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
