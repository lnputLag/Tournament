using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; }

        public static void InitializeConnections(bool database, bool textFiles)
        {
            Connections = new List<IDataConnection>();
            if (database)
            {
                // TODO - Создать SQL подключение
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if (textFiles) 
            {
                // TODO - Создать тектовое подклчюение
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
    }
}
