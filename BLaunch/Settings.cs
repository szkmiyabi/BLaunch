using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLaunch
{
    class Settings
    {
        private string _iePath;
        private string _ffPath;
        private string _gcPath;
        private string _etcBrowserPath;
        private string _pu_tag_link_img_alt_flag;
        private string _pu_tag_img_fname_flag;
        private string _pu_tag_img_alt_attr_flag;

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

        //コンストラクタ
        public Settings()
        {
            _iePath = "";
            _ffPath = "";
            _gcPath = "";
            _etcBrowserPath = "";
        }
    }
}
