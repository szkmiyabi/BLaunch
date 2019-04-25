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
            statusBar.Text = "ファイルを選択してください...";
            //環境設定をロード
            loadAppSettings();
            //imageボタンを設定
            imgButtonInit();
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
    }
}
