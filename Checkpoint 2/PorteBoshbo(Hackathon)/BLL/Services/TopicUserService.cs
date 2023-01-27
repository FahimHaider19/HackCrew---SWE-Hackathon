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
    public class TopicUserService
    {
        public static List<TopicUserDTO> Get(String department, String topic)
        {
            var topics = DataAccessFactory.TopicDataAccess().GetAll();
            List<TopicUserDTO> data= new List<TopicUserDTO>();
            foreach (var item in topics)
            {
                if (topic == "" && department != "" && department == item.Department.DepartmentName)
                {
                    foreach(var user in DataAccessFactory.UserTopicDataAccess().GetTopicUser(department, topic)) 
                    {
                        data.Add(new TopicUserDTO()
                        {
                            topic = new TopicDTO() { TopicId = item.TopicId, TopicName = item.TopicName },
                            user = new UserDTO() { UserId = user.UserId, Username=user.Username}
                        });
                    }
                }
                else if (department == "" && topic != "" && topic == item.TopicName)
                {
                    foreach (var user in DataAccessFactory.UserTopicDataAccess().GetTopicUser(department, topic))
                    {
                        data.Add(new TopicUserDTO()
                        {
                            topic = new TopicDTO() { TopicId = item.TopicId, TopicName = item.TopicName },
                            user = new UserDTO() { UserId = user.UserId, Username = user.Username }
                        });
                    }
                }
                else if (department != "" && topic != "" && department == item.Department.DepartmentName && topic == item.TopicName)
                {
                    foreach (var user in DataAccessFactory.UserTopicDataAccess().GetTopicUser(department, topic))
                    {
                        data.Add(new TopicUserDTO()
                        {
                            topic = new TopicDTO() { TopicId = item.TopicId, TopicName = item.TopicName },
                            user = new UserDTO() { UserId = user.UserId, Username = user.Username }
                        });
                    }
                }
                else
                    foreach (var user in DataAccessFactory.UserTopicDataAccess().GetTopicUser(department, topic))
                    {
                        data.Add(new TopicUserDTO()
                        {
                            topic = new TopicDTO() { TopicId = item.TopicId, TopicName = item.TopicName },
                            user = new UserDTO() { UserId = user.UserId, Username = user.Username }
                        });
                    }
            }
            return data;
        }
    }
}
