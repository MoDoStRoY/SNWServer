using Microsoft.AspNetCore.Mvc;
using SNWServer.Config.Objects.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SNWServer.ServerAPI.User
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetInfoController : Controller
    {
        Server server = Program.server;

        [HttpPost]
        [Route("getprofile")]
        public UserSNW GetProfile([FromBody] RequestBody body)
        {
            return server.usersList[0];
        }
    }
}
