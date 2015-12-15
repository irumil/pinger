using System.Collections.Generic;

namespace PingServersManager.Abstract
{
    public interface IServerListManager
    {
        List<ServerInfo> GetServerList();
        void SaveServerList(List<ServerInfo> serverList);
    }
}
