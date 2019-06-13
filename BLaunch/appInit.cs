using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BLaunch
{
    partial class Form1
    {

        private Settings appSettings;
        private string settings_filename;
        private string iePath;
        private string ffPath;
        private string gcPath;
        private string etcBrowserPath;
        private string cmdOptionStr;
        private string homeUrl;

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
                cmdOptionStr = appSettings.cmdOptionStr;
                homeUrl = appSettings.homeUrl;

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
            Bitmap homeImg = getImageFromResource("home.png");
            prevButton.Image = prevBtnImg;
            nextButton.Image = nextBtnImg;
            ieButton.Image = ieImg;
            ffButton.Image = ffImg;
            gcButton.Image = gcImg;
            anotherButton.Image = cfxImg;
            fileOpenButton.Image = folderImg;
            settingButton.Image = settingImg;
            homeButton.Image = homeImg;
        }

        //ファイル選択ダイアログの表示
        private void getOpenFileName()
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "テキストファイル(*.txt)|*.txt";
            if (f.ShowDialog() == DialogResult.OK)
            {
                filename = f.FileName;
            }
        }

        //ファイルをロード
        private void loadFile()
        {
            try
            {

                if (urlArray != null)
                {
                    urlArray = new ArrayList();
                    urlCombo.Items.Clear();
                }

                string buff = File.getTextFileContent(filename);
                string ext = File.getFileExtension(filename);

                if (ext.Equals(".txt"))
                {
                    urlArray = File.urlListDatasFromTextFile(buff);
                }
                else
                {
                    MessageBox.Show("サポートされないファイルを開こうとしました。処理をキャンセルします！");
                    return;
                }

                endOpen();

            }
            catch (Exception ex)
            {
                MessageBox.Show("処理エラーです。ファイルの内容に問題がないか確認してください！");
            }

        }

        //ファイルを開いた後の処理
        private void endOpen()
        {
            if (urlArray != null)
            {

                //無効化したコントロールを初期化
                urlCombo.Enabled = true;
                prevButton.Enabled = true;
                nextButton.Enabled = true;

                arrIndex = 0;
                //コンボボックスの生成
                for (int i = 0; i < urlArray.Count; i++)
                {
                    string[] inrow = (string[])urlArray[i];
                    urlCombo.Items.Add(inrow[0].ToString());
                }
                //初期値の設定
                string[] row = (string[])urlArray[0];
                urlText.Text = row[1].ToString();
                urlCombo.SelectedIndex = 0;
                statusBar.Text = filename;
            }
        }

        //IEでURLを開く
        private void browseByIE()
        {
            try
            {
                string burl = urlText.Text;
                System.Diagnostics.Process.Start(iePath, " " + burl);
            }
            catch (Exception ex)
            {
            }
        }

        //FirefoxでURLを開く
        private void browseByFirefox()
        {
            try
            {
                string burl = urlText.Text;
                System.Diagnostics.Process.Start(ffPath, "-new-tab " + burl);
            }
            catch (Exception ex)
            {
            }
        }

        //ChromeでURLを開く
        private void browseByChrome()
        {
            try
            {
                string burl = urlText.Text;
                System.Diagnostics.Process.Start(gcPath, " " + burl);
            }
            catch (Exception ex)
            {
            }
        }

        //任意のブラウザでURLを開く
        private void browseByAnother()
        {
            try
            {
                string burl = urlText.Text;
                string cr_cmd_option = "";
                if(cmdOptionStr.Equals(""))
                {
                    cr_cmd_option = "-new-tab ";
                }
                else
                {
                    cr_cmd_option = " " + cmdOptionStr + " " + "-new-tab ";
                }
                System.Diagnostics.Process.Start(etcBrowserPath, cr_cmd_option + burl);
            }
            catch (Exception ex)
            {
            }
        }

        //ホームURLに戻る
        private void browseHomeUrl()
        {
            if(homeUrl.Equals(""))
            {
                MessageBox.Show("ホームURLが設定されていません!");
                return;
            }
            else
            {
                urlText.Text = homeUrl;
            }
        }

    }
}
