using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BLaunch
{
    public partial class Form1 : Form
    {

        private string filename;
        private ArrayList urlArray;
        private int arrIndex;

        public Form1()
        {
            InitializeComponent();
            Initilalize();
        }

        //初期化
        private void Initilalize()
        {
            //statusBarを設定
            statusBar.Text = "ファイルを選択してください...";

            //常に前面表示の設定
            topMostCheck.Checked = true;
            TopMost = true;

            //環境設定をロード
            loadAppSettings();

            //imageボタンを設定
            imgButtonInit();

            //起動直後はコントロールを無効化
            prevButton.Enabled = false;
            nextButton.Enabled = false;
            urlCombo.Enabled = false;

            //ホームURLが指定されている場合はセットする
            if (!homeUrl.Equals("")) urlText.Text = homeUrl;

        }

        //前のURL
        private void doBrowserPrev()
        {
            if (urlArray != null)
            {
                if (arrIndex == 0)
                {
                    return;
                }
                arrIndex--;
                string[] row = (string[])urlArray[arrIndex];
                string urlNo = row[0].ToString();
                string urlStr = row[1].ToString();
                urlText.Text = urlStr;
                urlCombo.SelectedIndex = arrIndex;
            }
        }

        //次のURL
        private void doBrowserNext()
        {
            if (urlArray != null)
            {
                if (arrIndex == (urlArray.Count - 1))
                {
                    return;
                }
                arrIndex++;
                string[] row = (string[])urlArray[arrIndex];
                string urlNo = row[0].ToString();
                string urlStr = row[1].ToString();
                urlText.Text = urlStr;
                urlCombo.SelectedIndex = arrIndex;
            }
        }

        //comboで指定したURL
        private void doBrowseByCombo()
        {
            try
            {
                string keyVal = "";
                keyVal = urlCombo.SelectedItem.ToString();
                int pos = urlCombo.SelectedIndex;
                if (urlArray != null)
                {
                    string[] row = (string[])urlArray[pos];
                    string urlNo = row[0].ToString();
                    string urlStr = row[1].ToString();
                    urlText.Text = urlStr;
                    arrIndex = pos;
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        //環境設定をクリック
        private void settingButton_Click(object sender, EventArgs e)
        {
            showSettingDiag();
        }

        //開くをクリック
        private void fileOpenButton_Click(object sender, EventArgs e)
        {
            getOpenFileName();
            if (filename != null)
            {
                loadFile();
            }
        }

        //戻るをクリック
        private void prevButton_Click(object sender, EventArgs e)
        {
            doBrowserPrev();
        }

        //進むをクリック
        private void nextButton_Click(object sender, EventArgs e)
        {
            doBrowserNext();
        }

        //urlComboのPIDをクリック
        private void urlCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            doBrowseByCombo();
        }

        //IEで開くをクリック
        private void ieButton_Click(object sender, EventArgs e)
        {
            browseByIE();
        }

        //Firefoxで開くをクリック
        private void ffButton_Click(object sender, EventArgs e)
        {
            browseByFirefox();
        }

        //Chromeで開くをクリック
        private void gcButton_Click(object sender, EventArgs e)
        {
            browseByChrome();
        }

        //任意ブラウザで開くをクリック
        private void anotherButton_Click(object sender, EventArgs e)
        {
            browseByAnother();
        }

        //常に前面表示チェックボックスをクリック
        private void topMostCheck_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
        }

        //ホームURLをクリック
        private void homeButton_Click(object sender, EventArgs e)
        {
            browseHomeUrl();
        }
    }
}
