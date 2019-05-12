namespace BLaunch
{
    partial class SettingsDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dialogOKButton = new System.Windows.Forms.Button();
            this.dialogCancelButton = new System.Windows.Forms.Button();
            this.deleteSettingBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.etcBrowserPathLabel = new System.Windows.Forms.Label();
            this.gcPathLabel = new System.Windows.Forms.Label();
            this.ffPathLabel = new System.Windows.Forms.Label();
            this.iePathLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.iePathText = new System.Windows.Forms.TextBox();
            this.ieDefaultBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.ffPathText = new System.Windows.Forms.TextBox();
            this.ffDefaultBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.gcPathText = new System.Windows.Forms.TextBox();
            this.gcDefaultBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.etcBrowserText = new System.Windows.Forms.TextBox();
            this.homeUrlLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.homeUrlText = new System.Windows.Forms.TextBox();
            this.cmdOptionLabel = new System.Windows.Forms.Label();
            this.cmdOptionText = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.93832F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.06167F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(713, 237);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dialogOKButton);
            this.flowLayoutPanel1.Controls.Add(this.dialogCancelButton);
            this.flowLayoutPanel1.Controls.Add(this.deleteSettingBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(459, 197);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(251, 37);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // dialogOKButton
            // 
            this.dialogOKButton.Location = new System.Drawing.Point(3, 3);
            this.dialogOKButton.Name = "dialogOKButton";
            this.dialogOKButton.Size = new System.Drawing.Size(75, 23);
            this.dialogOKButton.TabIndex = 0;
            this.dialogOKButton.Text = "OK";
            this.dialogOKButton.UseVisualStyleBackColor = true;
            this.dialogOKButton.Click += new System.EventHandler(this.dialogOKButton_Click);
            // 
            // dialogCancelButton
            // 
            this.dialogCancelButton.Location = new System.Drawing.Point(84, 3);
            this.dialogCancelButton.Name = "dialogCancelButton";
            this.dialogCancelButton.Size = new System.Drawing.Size(75, 23);
            this.dialogCancelButton.TabIndex = 1;
            this.dialogCancelButton.Text = "キャンセル";
            this.dialogCancelButton.UseVisualStyleBackColor = true;
            this.dialogCancelButton.Click += new System.EventHandler(this.dialogCancelButton_Click);
            // 
            // deleteSettingBtn
            // 
            this.deleteSettingBtn.Location = new System.Drawing.Point(165, 3);
            this.deleteSettingBtn.Name = "deleteSettingBtn";
            this.deleteSettingBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteSettingBtn.TabIndex = 2;
            this.deleteSettingBtn.Text = "設定消去";
            this.deleteSettingBtn.UseVisualStyleBackColor = true;
            this.deleteSettingBtn.Click += new System.EventHandler(this.deleteSettingBtn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 554F));
            this.tableLayoutPanel2.Controls.Add(this.etcBrowserPathLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.gcPathLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.ffPathLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.iePathLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel4, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel5, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.homeUrlLabel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel6, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.98137F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.2236F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.84472F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.95031F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(707, 188);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // etcBrowserPathLabel
            // 
            this.etcBrowserPathLabel.AutoSize = true;
            this.etcBrowserPathLabel.Location = new System.Drawing.Point(3, 110);
            this.etcBrowserPathLabel.Name = "etcBrowserPathLabel";
            this.etcBrowserPathLabel.Size = new System.Drawing.Size(108, 12);
            this.etcBrowserPathLabel.TabIndex = 0;
            this.etcBrowserPathLabel.Text = "任意ブラウザ実行パス";
            // 
            // gcPathLabel
            // 
            this.gcPathLabel.AutoSize = true;
            this.gcPathLabel.Location = new System.Drawing.Point(3, 72);
            this.gcPathLabel.Name = "gcPathLabel";
            this.gcPathLabel.Size = new System.Drawing.Size(87, 12);
            this.gcPathLabel.TabIndex = 0;
            this.gcPathLabel.Text = "Chrome実行パス";
            // 
            // ffPathLabel
            // 
            this.ffPathLabel.AutoSize = true;
            this.ffPathLabel.Location = new System.Drawing.Point(3, 35);
            this.ffPathLabel.Name = "ffPathLabel";
            this.ffPathLabel.Size = new System.Drawing.Size(84, 12);
            this.ffPathLabel.TabIndex = 0;
            this.ffPathLabel.Text = "Firefox実行パス";
            // 
            // iePathLabel
            // 
            this.iePathLabel.AutoSize = true;
            this.iePathLabel.Location = new System.Drawing.Point(3, 0);
            this.iePathLabel.Name = "iePathLabel";
            this.iePathLabel.Size = new System.Drawing.Size(58, 12);
            this.iePathLabel.TabIndex = 0;
            this.iePathLabel.Text = "IE実行パス";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.iePathText);
            this.flowLayoutPanel2.Controls.Add(this.ieDefaultBtn);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(156, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(548, 29);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // iePathText
            // 
            this.iePathText.Location = new System.Drawing.Point(3, 3);
            this.iePathText.Name = "iePathText";
            this.iePathText.Size = new System.Drawing.Size(456, 19);
            this.iePathText.TabIndex = 1;
            // 
            // ieDefaultBtn
            // 
            this.ieDefaultBtn.Location = new System.Drawing.Point(465, 3);
            this.ieDefaultBtn.Name = "ieDefaultBtn";
            this.ieDefaultBtn.Size = new System.Drawing.Size(75, 23);
            this.ieDefaultBtn.TabIndex = 2;
            this.ieDefaultBtn.Text = "自動取得";
            this.ieDefaultBtn.UseVisualStyleBackColor = true;
            this.ieDefaultBtn.Click += new System.EventHandler(this.ieDefaultBtn_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.ffPathText);
            this.flowLayoutPanel3.Controls.Add(this.ffDefaultBtn);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(156, 38);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(548, 31);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // ffPathText
            // 
            this.ffPathText.Location = new System.Drawing.Point(3, 3);
            this.ffPathText.Name = "ffPathText";
            this.ffPathText.Size = new System.Drawing.Size(456, 19);
            this.ffPathText.TabIndex = 1;
            // 
            // ffDefaultBtn
            // 
            this.ffDefaultBtn.Location = new System.Drawing.Point(465, 3);
            this.ffDefaultBtn.Name = "ffDefaultBtn";
            this.ffDefaultBtn.Size = new System.Drawing.Size(75, 23);
            this.ffDefaultBtn.TabIndex = 2;
            this.ffDefaultBtn.Text = "自動取得";
            this.ffDefaultBtn.UseVisualStyleBackColor = true;
            this.ffDefaultBtn.Click += new System.EventHandler(this.ffDefaultBtn_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.gcPathText);
            this.flowLayoutPanel4.Controls.Add(this.gcDefaultBtn);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(156, 75);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(548, 32);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // gcPathText
            // 
            this.gcPathText.Location = new System.Drawing.Point(3, 3);
            this.gcPathText.Name = "gcPathText";
            this.gcPathText.Size = new System.Drawing.Size(456, 19);
            this.gcPathText.TabIndex = 1;
            // 
            // gcDefaultBtn
            // 
            this.gcDefaultBtn.Location = new System.Drawing.Point(465, 3);
            this.gcDefaultBtn.Name = "gcDefaultBtn";
            this.gcDefaultBtn.Size = new System.Drawing.Size(75, 23);
            this.gcDefaultBtn.TabIndex = 2;
            this.gcDefaultBtn.Text = "自動取得";
            this.gcDefaultBtn.UseVisualStyleBackColor = true;
            this.gcDefaultBtn.Click += new System.EventHandler(this.gcDefaultBtn_Click);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.etcBrowserText);
            this.flowLayoutPanel5.Controls.Add(this.cmdOptionLabel);
            this.flowLayoutPanel5.Controls.Add(this.cmdOptionText);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(156, 113);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(548, 37);
            this.flowLayoutPanel5.TabIndex = 3;
            // 
            // etcBrowserText
            // 
            this.etcBrowserText.Location = new System.Drawing.Point(3, 3);
            this.etcBrowserText.Name = "etcBrowserText";
            this.etcBrowserText.Size = new System.Drawing.Size(324, 19);
            this.etcBrowserText.TabIndex = 1;
            // 
            // homeUrlLabel
            // 
            this.homeUrlLabel.AutoSize = true;
            this.homeUrlLabel.Location = new System.Drawing.Point(3, 153);
            this.homeUrlLabel.Name = "homeUrlLabel";
            this.homeUrlLabel.Size = new System.Drawing.Size(57, 12);
            this.homeUrlLabel.TabIndex = 5;
            this.homeUrlLabel.Text = "ホームURL";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.homeUrlText);
            this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(156, 156);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(548, 29);
            this.flowLayoutPanel6.TabIndex = 6;
            // 
            // homeUrlText
            // 
            this.homeUrlText.Location = new System.Drawing.Point(3, 3);
            this.homeUrlText.Name = "homeUrlText";
            this.homeUrlText.Size = new System.Drawing.Size(537, 19);
            this.homeUrlText.TabIndex = 0;
            // 
            // cmdOptionLabel
            // 
            this.cmdOptionLabel.AutoSize = true;
            this.cmdOptionLabel.Location = new System.Drawing.Point(333, 0);
            this.cmdOptionLabel.Name = "cmdOptionLabel";
            this.cmdOptionLabel.Size = new System.Drawing.Size(72, 12);
            this.cmdOptionLabel.TabIndex = 2;
            this.cmdOptionLabel.Text = "起動オプション";
            // 
            // cmdOptionText
            // 
            this.cmdOptionText.Location = new System.Drawing.Point(411, 3);
            this.cmdOptionText.Name = "cmdOptionText";
            this.cmdOptionText.Size = new System.Drawing.Size(129, 19);
            this.cmdOptionText.TabIndex = 3;
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 237);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SettingsDialog";
            this.Text = "環境設定";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button dialogOKButton;
        private System.Windows.Forms.Button dialogCancelButton;
        private System.Windows.Forms.Button deleteSettingBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label etcBrowserPathLabel;
        private System.Windows.Forms.Label gcPathLabel;
        private System.Windows.Forms.Label ffPathLabel;
        private System.Windows.Forms.Label iePathLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox iePathText;
        private System.Windows.Forms.Button ieDefaultBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TextBox ffPathText;
        private System.Windows.Forms.Button ffDefaultBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.TextBox gcPathText;
        private System.Windows.Forms.Button gcDefaultBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.TextBox etcBrowserText;
        private System.Windows.Forms.Label homeUrlLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.TextBox homeUrlText;
        private System.Windows.Forms.Label cmdOptionLabel;
        private System.Windows.Forms.TextBox cmdOptionText;
    }
}