using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class RequestDTO
    {
        public int RequestId { get; set; }
        public int StudentId { get; set; }
        public int TopicId { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
    }
}
