using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteMVC.Models
{
    public class UserAndTopic
    {
        public int UserId { get; set; }
        public UserInformation User { get; set; }
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
    }
}
