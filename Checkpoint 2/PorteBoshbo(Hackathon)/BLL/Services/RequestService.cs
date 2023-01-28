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
    public static class RequestService
    {
        public static List<RequestDTO> Get()
        {
            var requests = new List<RequestDTO>();
            var requestdb = DataAccessFactory.RequestDataAccess().GetAll();
            foreach (var request in requestdb)
            {
                requests.Add(new RequestDTO()
                {
                    RequestId = (int)request.RequestId,
                    StudentId = (int)request.StudentId,
                    TopicId = (int)request.TopicId,
                    Status = request.Status,
                    Date = (DateTime)request.Date
                });
            }
            return requests;
        }
        public static RequestDTO Get(int id)
        {
            var requestdb = DataAccessFactory.RequestDataAccess().Get(id);
            var request = new RequestDTO()
            {
                RequestId = (int)requestdb.RequestId,
                StudentId = (int)requestdb.StudentId,
                TopicId = (int)requestdb.TopicId,
                Status = requestdb.Status,
                Date = (DateTime)requestdb.Date
            };
            return request;
        }
        public static bool Add(RequestDTO request)
        {
            var requestdb = new Request()
            {
                RequestId = request.RequestId,
                StudentId = request.StudentId,
                TopicId = request.TopicId,
                Status = request.Status,
                Date = request.Date
            };
            return DataAccessFactory.RequestDataAccess().Add(requestdb);
        }
        public static bool Update(RequestDTO request)
        {
            var requestdb = DataAccessFactory.RequestDataAccess().Get(request.RequestId);

            return DataAccessFactory.RequestDataAccess().Update(requestdb);
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.RequestDataAccess().Remove(id);
        }

        public static int total()
        {
            var requests = new List<RequestDTO>();
            int total = 0;
            var requestdb = DataAccessFactory.RequestDataAccess().GetAll();
            foreach (var request in requestdb)
            {
                total++;

            }
            return total;
        }
    }
}


