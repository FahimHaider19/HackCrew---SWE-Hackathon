using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class PostRepo : IRepo<Post>
    {
        private PorteBoshboEntities db = new PorteBoshboEntities();
        public bool Add(Post obj)
        {
            db.Posts.Add(obj);
            return db.SaveChanges() > 0;
        }

        public Post Get(int id)
        {
            return db.Posts.Find(id);
        }

        public List<Post> GetAll()
        {
            return db.Posts.ToList();
        }

        public bool Remove(int id)
        {
            db.Posts.Remove(Get(id));
            return db.SaveChanges() > 0;
        }

        public bool Update(Post obj)
        {
            db.Entry(Get(obj.PostId)).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
