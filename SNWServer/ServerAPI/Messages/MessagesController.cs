using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SNWServer.Config.Objects.Messages;
using SNWServer.Config.Objects.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SNWServer.ServerAPI.Messages
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        Server server = Program.server;

        [HttpPost]
        [Route ("send")]
        public List<Message> SendMessage([FromBody]Message message)
        {
            server.messagesList.Add(message);

            return server.messagesList;
        }
    }
}
