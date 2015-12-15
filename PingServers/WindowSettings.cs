using System.IO;
using System.Xml.Serialization;

namespace PingServers
{
    public class WindowSettings
    {
        private bool _isCompact;
        private int _transparent;
        private int _top;
        private int _left;
        private int _height;
        private int _width;
        private int _countVoiceWarning;
        private string _voiceText;

        private const string FileName = "windowSettings.xml";

        private bool _settingChanged;

        public static WindowSettings GetSettings()
        {
            WindowSettings windowSettings = new WindowSettings();

            if (!File.Exists(FileName)) return windowSettings;

            {
                using (FileStream fs = new FileStream(FileName, FileMode.Open))
                {
                    XmlSerializer xmlSettings = new XmlSerializer(typeof(WindowSettings));
                    windowSettings = (WindowSettings)xmlSettings.Deserialize(fs);
                    fs.Close();
                }
            }
            return windowSettings;
        }

        public void Save()
        {
            if (!_settingChanged) return;

            if (File.Exists(FileName)) File.Delete(FileName);

            using (FileStream fs = new FileStream(FileName, FileMode.Create))
            {
                XmlSerializer xmlSettings = new XmlSerializer(typeof(WindowSettings));
                xmlSettings.Serialize(fs, this);
                fs.Close();
            }
        }
        private void ChangeSetting()
        {
            _settingChanged = true;
        }

        public bool IsCompact
        {
            get { return _isCompact; }
            set
            {
                _isCompact = value;
                ChangeSetting();
            }
        } 
        
        public int Transparent
        {
            get { return _transparent <= 30 ? 100 : _transparent; }
            set
            {
                _transparent = value;
                ChangeSetting();
            }
        }
        
        public int Top
        {
            get { return _top <= 4 ? 4 : _top; }
            set
            {
                _top = value;
                ChangeSetting();
            }
        }

        public int Left
        {
            get { return _left<=4 ? 4: _left; }
            set
            {
                _left  = value;
                ChangeSetting();
            }
        }

        public int Height
        {
            get{ return _height<=4 ? 4: _height; }
            set
            {
                _height = value;
                ChangeSetting();
            } 
        }

        public int Width
        {
            get{ return _width<=4 ? 4: _width; }
            set
            {
                _width = value;
                ChangeSetting();
            }
        }

        public int CountVoiceWarning
        {
            get { return _countVoiceWarning; }
            set
            {
                _countVoiceWarning = value;
                ChangeSetting();
            }
        }

        public string VoiceText
        {
            get { return _voiceText; }
            set
            {
                _voiceText = value;
                ChangeSetting();
            }
        }

        
        
    }
}
