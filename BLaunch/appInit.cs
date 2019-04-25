using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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

        //imageリソースを取得
        private Bitmap getImageFromResource(string imgname)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream stream = assembly.GetManifestResourceStream("BLaunch.resources." + imgname);
            Bitmap bmp = new Bitmap(stream);
            return bmp;
        }

        //イメージボタン初期化
        private void imgButtonInit()
        {
            Bitmap prevBtnImg = getImageFromResource("prevbutton30.png");
            Bitmap nextBtnImg = getImageFromResource("nextbutton30.png");
            Bitmap ieImg = getImageFromResource("ie32.png");
            Bitmap ffImg = getImageFromResource("ff32.png");
            Bitmap gcImg = getImageFromResource("gc32.png");
            Bitmap cfxImg = getImageFromResource("cfx32.png");
            Bitmap folderImg = getImageFromResource("folder.png");
            Bitmap settingImg = getImageFromResource("setting.png");
            prevButton.Image = prevBtnImg;
            nextButton.Image = nextBtnImg;
            ieButton.Image = ieImg;
            ffButton.Image = ffImg;
            gcButton.Image = gcImg;
            anotherButton.Image = cfxImg;
            fileOpenButton.Image = folderImg;
            settingButton.Image = settingImg;
        }

    }
}
