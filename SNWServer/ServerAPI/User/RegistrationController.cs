using Microsoft.AspNetCore.Mvc;
using SNWServer.Config.Objects.System;
using System.Collections.Generic;

namespace SNWServer.ServerAPI.User
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : Controller
    {
        Server server = Program.server;

        [HttpPost]
        [Route("registration")]
        public string Registration([FromBody] UserSNW user)
        {
            server.usersList.Add(user);

            return "ОК";
        }
    }
}
