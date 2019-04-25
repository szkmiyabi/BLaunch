using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BLaunch
{
    partial class Form1
    {

        private Settings appSettings;
        private static string settings_filename = "settings.config";
        private string iePath;
        private string ffPath;
        private string gcPath;
        private string etcBrowserPath;

        //アプリ設定データを取得
        private void loadAppSettings()
        {
            try
            {
                appSettings = new Settings();
                XmlSerializer xsz = new XmlSerializer(typeof(Settings));
                StreamReader sr = new StreamReader(
                    settings_filename,
                    new System.Text.UTF8Encoding(false)
                );
                appSettings = (Settings)xsz.Deserialize(sr);
                sr.Close();

                iePath = appSettings.iePath;
                ffPath = appSettings.ffPath;
                gcPath = appSettings.gcPath;
                etcBrowserPath = appSettings.etcBrowserPath;

            }
            catch (Exception ex)
            {

            }

        }

        //設定ダイアログを表示
        private void showSettingDiag()
        {
            SettingsDialog sd = new SettingsDialog();
            sd.ShowDialog(this);
            sd.Dispose();
            //設定を再読込
            loadAppSettings();
        }

    }
}
