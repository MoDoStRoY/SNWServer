using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public List<String> SendMessage([FromBody]String message)
        {
            System.Diagnostics.Debug.WriteLine(message);
            server.messagesList.Add(message);

            return server.messagesList;
        }
    }
}
