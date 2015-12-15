using System;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Xml.Serialization;
using BindingListSerializator;

namespace PingServersManager
{
    public class ServerManager
    {
        private readonly System.Timers.Timer _timerForPingServer;
        private readonly XmlSettingsServerManager _xmlSettings;

        private readonly BindingList<ServerInfo> _serverListManager;
        private readonly IManageList<ServerInfo> _serverManagerList = new XmlManageList<ServerInfo>();

        public event Action<string> PingProcessCompleted;
        public event Action<string> PingTimeOutEvent;
        
        public ServerManager(bool enabled=false)
        {
            _xmlSettings = XmlSettingsServerManager.GetSettings();

            _serverListManager =  _serverManagerList.ReadList();
            _serverListManager.ListChanged += OnListChange;

            foreach (var serverInfo in _serverListManager)
            {
                serverInfo.OnPingComplete += PingCompleteManager;
                serverInfo.OnTimeOutWarning += TimeOutWarning;
            }

            _timerForPingServer = new System.Timers.Timer
            {
                Interval = _xmlSettings.IntervalTimer * 1000,
                Enabled = enabled
            };
            _timerForPingServer.Elapsed += OnTimerPing;
            _timerForPingServer.AutoReset = true;                  
        }

        private void TimeOutWarning(string serverName)
        {
            if (PingTimeOutEvent != null) PingTimeOutEvent(serverName);
        }

        public bool IsServerListChanged
        {
            get;
            private set;
        }

        private void OnListChange(object sender, ListChangedEventArgs e)
        {
            try
            {
                if (e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted)
                {
                    IsServerListChanged = true;
                }
                if (!e.PropertyDescriptor.Attributes.OfType<XmlIgnoreAttribute>().Any())
                {
                    IsServerListChanged = true;
                }
            }
            catch (Exception)
            {
                //запишем в лог ошибок
            }
        }

        ~ServerManager()
        {
            _timerForPingServer.Enabled = false;
            Thread.Sleep(1000);
            
            SaveServerList();
            _xmlSettings.Save();
        }

        public void SaveServerList()
        {
            if (!IsServerListChanged) return;
            _serverManagerList.SaveList(_serverListManager);
            IsServerListChanged = false;
        }

        private void OnTimerPing(object source, System.Timers.ElapsedEventArgs e)
        {
            //разделяем промежуток для пинга
            var countNeedPingServers = _serverListManager.Count(sI => sI.PingThisServer);
            var timeOutForPing = _timerForPingServer.Interval / countNeedPingServers;

            foreach (ServerInfo serverInfo in _serverListManager.Where(sI => sI.PingThisServer))
            {
                serverInfo.Ping();
                Thread.Sleep((int) timeOutForPing);
            }
        }

        public int IntervalTimer
        {
            get { return _xmlSettings.IntervalTimer; }
            set
            {
                _xmlSettings.IntervalTimer = value;
                _timerForPingServer.Interval = value * 1000;
            }
        }        
        
        public void StartStop()
        {
            _timerForPingServer.Enabled = !_timerForPingServer.Enabled;
        }

        public void AddServer()
        {
            var newServer = new ServerInfo{
                ServerIP = "localhost",
                ServerName = "localhost", 
                PingFlag = false,
                TimeOut = 320,
                CountForWarning = 5
            };

            newServer.OnPingComplete += PingCompleteManager;
            newServer.OnTimeOutWarning += TimeOutWarning;
            _serverListManager.Add(newServer);
            IsServerListChanged = true;
        }

        private void PingCompleteManager(string info)
        {
            if (PingProcessCompleted!=null) PingProcessCompleted(info);
        }

        public void RemoveServer(int serverIndex)
        {
            _serverListManager.RemoveAt(serverIndex);
            IsServerListChanged = true;
        }
        
        public BindingList<ServerInfo> GetServerList()
        {
            return _serverListManager;
        }
    }
}