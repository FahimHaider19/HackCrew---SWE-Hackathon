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
    public static class CommentService
    {
        public static List<CommentDTO> Get()
        {
            var comments = new List<CommentDTO>();
            var commentdb = DataAccessFactory.CommentDataAccess().GetAll();
            foreach (var comment in commentdb)
            {
                comments.Add(new CommentDTO()
                {
                    CommentId = comment.CommentId,
                    PostId = (int)comment.PostId,
                    TopicId = (int)comment.TopicId,
                    UserId = (int)comment.UserId,
                    Date = (DateTime)comment.Date,
                    Text = (string)comment.text
                });
            }
            return comments;
        }
        public static CommentDTO Get(int id)
        {
            var commentdb = DataAccessFactory.CommentDataAccess().Get(id);
            var comment = new CommentDTO()
            {
                CommentId = commentdb.CommentId,
                PostId = (int)commentdb.PostId,
                TopicId = (int)commentdb.TopicId,
                UserId = (int)commentdb.UserId,
                Date = (DateTime)commentdb.Date,
                Text = (string)commentdb.text
            };
            return comment;
        }
        public static bool Add(CommentDTO comment)
        {
            var commentdb = new Comment()
            {
                CommentId = comment.CommentId,
                PostId = comment.PostId,
                TopicId = comment.TopicId,
                UserId = comment.UserId,
                Date = comment.Date,
                text = comment.Text
            };
            return DataAccessFactory.CommentDataAccess().Add(commentdb);
        }
        public static bool Update(CommentDTO comment)
        {
            var commentdb = DataAccessFactory.CommentDataAccess().Get(comment.CommentId);

            return DataAccessFactory.CommentDataAccess().Update(commentdb);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.CommentDataAccess().Remove(id);
        }

        public static int total()
        {
            var comments = new List<CommentDTO>();
            int total = 0;  
            var commentdb = DataAccessFactory.CommentDataAccess().GetAll();
            foreach (var comment in commentdb)
            {
                total++;

            }
            return total;
        }
    }
}

