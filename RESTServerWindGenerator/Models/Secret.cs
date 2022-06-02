using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTServerWindGenerator.Models
{
    public class Secret
    {
        public static readonly string ConnctionString =
        //"Data Source=apifirstserver.database.windows.net;Initial Catalog=RESTdb;User ID=ApiServer;Password=12345678@JA;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        "Server=tcp:apifirstserver.database.windows.net,1433;Initial Catalog=RESTdb;Persist Security Info=False;User ID=ApiServer;Password=12345678@JA;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
    }
}