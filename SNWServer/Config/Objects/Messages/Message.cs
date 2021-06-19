using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SNWServer.Config.Objects.Messages
{
    public class Message
    {
        public string dateTime { get; set; }
        public string senderName { get; set; }
        public string body { get; set; }
    }
}
