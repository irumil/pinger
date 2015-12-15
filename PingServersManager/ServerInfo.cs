using System;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Xml.Serialization;

namespace PingServersManager
{
    [Serializable]
    public class ServerInfo : INotifyPropertyChanged
    {
        #region Private Fields
        private string _serverName;
        private string _serverIP;
        private bool _pingThisServer;
        private bool _pingFlag;
        private int _timeOut;
        private int _timeOutCounter;
        private string _pingInfo;
        private int _countForWarning; 

        readonly AutoResetEvent _waiter = new AutoResetEvent(false);
        #endregion Private Fileds

        #region Public Events
        public event Action<string> OnPingComplete;
        public event Action<string> OnTimeOutWarning;
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion Public Events
        
        #region Public Properties
        [DisplayName("Пинговать")]
        public bool PingThisServer
        {
            get { return _pingThisServer; }
            set
            {
                _pingThisServer = value;
                OnPropertyChanged("PingThisServer");
            }
        }

        [DisplayName("Сервер")]
        public string ServerName
        {
            get {return _serverName;}
            set
            {
                _serverName = value;
                OnPropertyChanged("ServerName");
            }
        }

        [DisplayName("IP Адрес")]
        public string ServerIP
        {
            get { return _serverIP; }
            set
            {
                _serverIP = value;
                OnPropertyChanged("ServerIP");
            }
        }

        [XmlIgnore]
        public bool PingFlag
        {
            get { return _pingFlag; }
            set
            {
                _pingFlag = value;
                OnPropertyChanged("PingFlag");
            }
        }
        
        [DisplayName("TimeOut")]
        public int TimeOut
        {
            get { return _timeOut; }
            set
            {
                _timeOut = value;
                OnPropertyChanged("TimeOut");
            } 
        }

        [DisplayName("Предупреждение")]
        public int CountForWarning
        {
            get
            {
                return _countForWarning; 
            }
            set
            {
                _countForWarning = value;
                OnPropertyChanged("CountForWarning");
            }
        }
        #endregion Public Properties

        #region Private Properties
        private string Status
        {
            set
            {
                if (value == "Success")
                {
                    _pingFlag = true;
                    _timeOutCounter = 0;
                }
                else
                {
                    _pingFlag = false;
                    _timeOutCounter += 1;
                }
                OnPropertyChanged("Status");
            }
            get
            {
                return _pingFlag ? "Success" : "TimeOut";
            }
        }
        #endregion Private Properties

        #region Public Methods
        public void Ping()
        {
            using (Ping ping = new Ping())
            {
                ping.PingCompleted += PingCompletedCallback;
                ping.SendAsync(_serverIP, _timeOut, _waiter);
                _waiter.WaitOne();
            }
        }
        #endregion Public Methods

        #region Private Methods
        private bool IsTimeOutCounterFull(int countTimeOut)
        {
            if (_timeOutCounter < countTimeOut) return false;

            _timeOutCounter = 0;
            return true;
        }

        private void PingCompletedCallback(object sender, PingCompletedEventArgs e)
        {
            PingReply pingReply = e.Reply;
            ((AutoResetEvent)e.UserState).Set();
            Status = pingReply.Status.ToString();
            
            StringBuilder pingInfo = new StringBuilder();
            pingInfo.AppendFormat("{0} \t{1,-15} \t{2,-15} ", _serverName, _serverIP, Status);
            pingInfo.AppendFormat(_pingFlag ? "\t{0}мс" : "\t{0}",
                                  _pingFlag ? pingReply.RoundtripTime.ToString() : "Превышен интервал ожидания для запроса");
            pingInfo.AppendLine();
            _pingInfo = pingInfo.ToString();

            if (OnPingComplete!= null) OnPingComplete(_pingInfo);

            if (_countForWarning <= 0) return;
            if (!IsTimeOutCounterFull(_countForWarning)) return;
            if (OnTimeOutWarning != null) OnTimeOutWarning(_serverName);
        }
        
        protected virtual void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(name));
        }
        #endregion Private Methods
    }
}
