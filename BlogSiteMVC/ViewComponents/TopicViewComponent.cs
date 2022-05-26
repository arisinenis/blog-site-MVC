using Business.Abstract;
using Core.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteMVC.ViewComponents
{
    public class TopicViewComponent : ViewComponent
    {
        private readonly ITopicService topicService;
        public TopicViewComponent(ITopicService topicService)
        {
            this.topicService = topicService;
        }

        public IViewComponentResult Invoke()
        {
            IEnumerable<Topic> topics = topicService.GetAll();

            return View(topics);
        }
    }
}
