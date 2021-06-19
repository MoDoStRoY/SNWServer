using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SNWServer.Config.Objects.System
{
    public class UserSNW
    {
        public string name { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public bool agree { get; set; }
    }
}
