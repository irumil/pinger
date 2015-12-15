using System.IO;
using System.Xml.Serialization;

namespace PingServersManager
{   
    public class XmlSettingsServerManager 
    {
        private int _intervalTimer;
        private bool _settingChanged;

        private const string FileName = "settingManager.xml";
        
        public static XmlSettingsServerManager GetSettings()
        {
            XmlSettingsServerManager settingsServer = new XmlSettingsServerManager();

            if (!File.Exists(FileName)) return settingsServer;

            {
                using (FileStream fs = new FileStream(FileName, FileMode.Open))
                {
                    XmlSerializer xmlSettings = new XmlSerializer(typeof(XmlSettingsServerManager));
                    settingsServer = (XmlSettingsServerManager) xmlSettings.Deserialize(fs);
                    fs.Close();
                }
            }
            return settingsServer;
        }

        public void Save()
        {
            if (!_settingChanged) return;
            
            if (File.Exists(FileName)) File.Delete(FileName);

            using (FileStream fs = new FileStream(FileName, FileMode.Create))
            {
                XmlSerializer xmlSettings = new XmlSerializer(typeof (XmlSettingsServerManager));
                xmlSettings.Serialize(fs, this);
                fs.Close();
            }
        }

        private void ChangeSetting()
        {
            _settingChanged = true;
        }

        public int IntervalTimer
        {
            get { return _intervalTimer < 2 ? 2 : _intervalTimer; }
            set
                {
                    _intervalTimer = value;
                    ChangeSetting();
                }
        }

    }
}
