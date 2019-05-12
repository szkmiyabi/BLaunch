using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLaunch
{
    public class Settings
    {
        private string _iePath;
        private string _ffPath;
        private string _gcPath;
        private string _etcBrowserPath;
        private string _cmdOptionStr;
        private string _homeUrl;

        public string iePath
        {
            get { return _iePath; }
            set { _iePath = value; }
        }
        public string ffPath
        {
            get { return _ffPath; }
            set { _ffPath = value; }
        }
        public string gcPath
        {
            get { return _gcPath; }
            set { _gcPath = value; }
        }
        public string etcBrowserPath
        {
            get { return _etcBrowserPath; }
            set { _etcBrowserPath = value; }
        }
        public string cmdOptionStr
        {
            get { return _cmdOptionStr; }
            set { _cmdOptionStr = value; }
        }
        public string homeUrl
        {
            get { return _homeUrl; }
            set { _homeUrl = value; }
        }

        //コンストラクタ
        public Settings()
        {
            _iePath = "";
            _ffPath = "";
            _gcPath = "";
            _etcBrowserPath = "";
            _cmdOptionStr = "";
            _homeUrl = "";
        }
    }
}
