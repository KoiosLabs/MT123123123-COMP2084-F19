using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MT123123123.Models
{
    public class ForumViewModel
    {
        public Message Message { get; set; }
        public IEnumerable<Message> MessageList { get; set; }
    }
}
