using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Snowflake.Net
{
   public static class MainID
    {
        static IdWorker id;
        static MainID()
        {
            id = new IdWorker(1,1);
        }
        [Microsoft.SqlServer.Server.SqlFunction]
        public static long GetID()
        {
            return id.NextId();
        }
    }
}
