using System;
using System.Collections.Generic;
using System.Text;

namespace Beirinha.DesignPatterns.Behavioral.Command
{
    public class ServerCommand : CommandAbstract
    {
        private Server _server;

        public ServerCommand(Server server)
        {
            this._server = server;
        }

        public override void Execute()
        {
            _server.ValidateUser();
        }
    }
}
