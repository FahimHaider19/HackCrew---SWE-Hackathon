using BLL.DTOs;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public static class PostService
    {
        public static List<PostDTO> Get()
        {
            var posts = new List<PostDTO>();
            var postdb = DataAccessFactory.PostDataAccess().GetAll();
            foreach (var post in postdb)
            {
                posts.Add(new PostDTO()
                {
                    PostId = post.PostId,
                    TopicId = post.TopicId,
                    UserId = post.UserId,
                    Date = post.Date,
                    Text = post.Text
                });
            }
            return posts;
        }
        public static PostDTO Get(int id)
        {
            var postdb = DataAccessFactory.PostDataAccess().Get(id);
            var post = new PostDTO()
            {
                PostId = postdb.PostId,
                TopicId = postdb.TopicId,
                UserId = postdb.UserId,
                Date = postdb.Date,
                Text = postdb.Text
            };
            return post;
        }
        public static bool Add(PostDTO post)
        {
            var postdb = new Post()
            {
                PostId = post.PostId,
                TopicId = post.TopicId,
                UserId = post.UserId,
                Date = post.Date,
                Text = post.Text
            };
            return DataAccessFactory.PostDataAccess().Add(postdb);
        }
        public static bool Update(PostDTO post)
        {
            var postdb = DataAccessFactory.PostDataAccess().Get(post.PostId);

            return DataAccessFactory.PostDataAccess().Update(postdb);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.PostDataAccess().Remove(id);
        }

        public static int total()
        {
            var posts = new List<PostDTO>();
            int total = 0;
            var postdb = DataAccessFactory.PostDataAccess().GetAll();
            foreach (var post in postdb)
            {
                total++;

            }
            return total;
        }
    }
}

