using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CommentDTO
    {
        public int CommentId { get; set; }
        public int PostId { get; set; }
        public int TopicId { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }
}
