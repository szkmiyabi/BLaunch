namespace BLaunch
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.urlCombo = new System.Windows.Forms.ComboBox();
            this.urlText = new System.Windows.Forms.TextBox();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.fileOpenButton = new System.Windows.Forms.Button();
            this.settingButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.ieButton = new System.Windows.Forms.Button();
            this.ffButton = new System.Windows.Forms.Button();
            this.gcButton = new System.Windows.Forms.Button();
            this.anotherButton = new System.Windows.Forms.Button();
            this.topMostCheck = new System.Windows.Forms.CheckBox();
            this.opacityCheck = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.95146F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.04855F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(558, 93);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.urlCombo);
            this.flowLayoutPanel1.Controls.Add(this.urlText);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(552, 26);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // urlCombo
            // 
            this.urlCombo.FormattingEnabled = true;
            this.urlCombo.Location = new System.Drawing.Point(3, 3);
            this.urlCombo.Name = "urlCombo";
            this.urlCombo.Size = new System.Drawing.Size(96, 20);
            this.urlCombo.TabIndex = 0;
            this.urlCombo.SelectedIndexChanged += new System.EventHandler(this.urlCombo_SelectedIndexChanged);
            // 
            // urlText
            // 
            this.urlText.Location = new System.Drawing.Point(105, 3);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(440, 19);
            this.urlText.TabIndex = 1;
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(111, 3);
            this.prevButton.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(32, 32);
            this.prevButton.TabIndex = 2;
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(147, 3);
            this.nextButton.Margin = new System.Windows.Forms.Padding(3, 3, 9, 3);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(32, 32);
            this.nextButton.TabIndex = 3;
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.fileOpenButton);
            this.flowLayoutPanel2.Controls.Add(this.settingButton);
            this.flowLayoutPanel2.Controls.Add(this.homeButton);
            this.flowLayoutPanel2.Controls.Add(this.prevButton);
            this.flowLayoutPanel2.Controls.Add(this.nextButton);
            this.flowLayoutPanel2.Controls.Add(this.ieButton);
            this.flowLayoutPanel2.Controls.Add(this.ffButton);
            this.flowLayoutPanel2.Controls.Add(this.gcButton);
            this.flowLayoutPanel2.Controls.Add(this.anotherButton);
            this.flowLayoutPanel2.Controls.Add(this.topMostCheck);
            this.flowLayoutPanel2.Controls.Add(this.opacityCheck);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 35);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(552, 40);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // fileOpenButton
            // 
            this.fileOpenButton.Location = new System.Drawing.Point(3, 3);
            this.fileOpenButton.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.fileOpenButton.Name = "fileOpenButton";
            this.fileOpenButton.Size = new System.Drawing.Size(32, 32);
            this.fileOpenButton.TabIndex = 4;
            this.fileOpenButton.UseVisualStyleBackColor = true;
            this.fileOpenButton.Click += new System.EventHandler(this.fileOpenButton_Click);
            // 
            // settingButton
            // 
            this.settingButton.Location = new System.Drawing.Point(39, 3);
            this.settingButton.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(32, 32);
            this.settingButton.TabIndex = 9;
            this.settingButton.UseVisualStyleBackColor = true;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(75, 3);
            this.homeButton.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(32, 32);
            this.homeButton.TabIndex = 11;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // ieButton
            // 
            this.ieButton.Location = new System.Drawing.Point(191, 3);
            this.ieButton.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.ieButton.Name = "ieButton";
            this.ieButton.Size = new System.Drawing.Size(32, 32);
            this.ieButton.TabIndex = 5;
            this.ieButton.UseVisualStyleBackColor = true;
            this.ieButton.Click += new System.EventHandler(this.ieButton_Click);
            // 
            // ffButton
            // 
            this.ffButton.Location = new System.Drawing.Point(227, 3);
            this.ffButton.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.ffButton.Name = "ffButton";
            this.ffButton.Size = new System.Drawing.Size(32, 32);
            this.ffButton.TabIndex = 6;
            this.ffButton.UseVisualStyleBackColor = true;
            this.ffButton.Click += new System.EventHandler(this.ffButton_Click);
            // 
            // gcButton
            // 
            this.gcButton.Location = new System.Drawing.Point(263, 3);
            this.gcButton.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.gcButton.Name = "gcButton";
            this.gcButton.Size = new System.Drawing.Size(32, 32);
            this.gcButton.TabIndex = 7;
            this.gcButton.UseVisualStyleBackColor = true;
            this.gcButton.Click += new System.EventHandler(this.gcButton_Click);
            // 
            // anotherButton
            // 
            this.anotherButton.Location = new System.Drawing.Point(299, 3);
            this.anotherButton.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.anotherButton.Name = "anotherButton";
            this.anotherButton.Size = new System.Drawing.Size(32, 32);
            this.anotherButton.TabIndex = 8;
            this.anotherButton.UseVisualStyleBackColor = true;
            this.anotherButton.Click += new System.EventHandler(this.anotherButton_Click);
            // 
            // topMostCheck
            // 
            this.topMostCheck.AutoSize = true;
            this.topMostCheck.Location = new System.Drawing.Point(346, 15);
            this.topMostCheck.Margin = new System.Windows.Forms.Padding(14, 15, 3, 3);
            this.topMostCheck.Name = "topMostCheck";
            this.topMostCheck.Size = new System.Drawing.Size(93, 16);
            this.topMostCheck.TabIndex = 10;
            this.topMostCheck.Text = "常に前面表示";
            this.topMostCheck.UseVisualStyleBackColor = true;
            this.topMostCheck.Click += new System.EventHandler(this.topMostCheck_Click);
            // 
            // opacityCheck
            // 
            this.opacityCheck.AutoSize = true;
            this.opacityCheck.Location = new System.Drawing.Point(445, 15);
            this.opacityCheck.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.opacityCheck.Name = "opacityCheck";
            this.opacityCheck.Size = new System.Drawing.Size(72, 16);
            this.opacityCheck.TabIndex = 12;
            this.opacityCheck.Text = "透過表示";
            this.opacityCheck.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 71);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(558, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusBar
            // 
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 93);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BLaunch";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox urlCombo;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button fileOpenButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button ieButton;
        private System.Windows.Forms.Button ffButton;
        private System.Windows.Forms.Button gcButton;
        private System.Windows.Forms.Button anotherButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusBar;
        private System.Windows.Forms.Button settingButton;
        private System.Windows.Forms.CheckBox topMostCheck;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.CheckBox opacityCheck;
    }
}

