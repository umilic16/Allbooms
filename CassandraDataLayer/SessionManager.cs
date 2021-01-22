using System;
using Cassandra;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassandraDataLayer
{
    public static class SessionManager
    {
        public static ISession session;

        public static ISession GetSession()
        {
            if(session==null)
            {
                Cluster cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build();
                session = cluster.Connect("Allbooms");
            }
            return session;
        }
    }
}
