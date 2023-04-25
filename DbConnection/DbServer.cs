using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnection
{
    [Serializable]
    public class DbServer
    {
        public string ServerName { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public string Password { get; set; }
        public bool SavePassword { get; set; }
        public ServerStatus Status { get; set; }

        public DbServer() { }

        public DbServer(string serverName, string host, int port, string password, bool savePassword) 
        {
            ServerName = serverName;
            Host = host;
            Port = port;
            Password = password;
            SavePassword = savePassword;
            Status = ServerStatus.UNKNOWN;
        }

        public DbServer(string serverName, string host, int port, string password, bool savePassword, ServerStatus status)
        {
            ServerName = serverName;
            Host = host;
            Port = port;
            Password = password;
            SavePassword = savePassword;
            Status = status;
        }
    }
}
