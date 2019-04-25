﻿using System;
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

        //環境設定をクリック
        private void settingButton_Click(object sender, EventArgs e)
        {
            showSettingDiag();
        }

        private void fileOpenButton_Click(object sender, EventArgs e)
        {
            getOpenFileName();
            if (filename != null)
            {
                loadFile();
            }
        }
    }
}
