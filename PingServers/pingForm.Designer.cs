namespace PingServers
{
    partial class PingForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PingForm));
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.serverDataGridView = new System.Windows.Forms.DataGridView();
            this.pingThisServer = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountForWarning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pingButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PingFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.warningVoiceUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.intervalUpDown = new System.Windows.Forms.NumericUpDown();
            this.voiceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolBarPanel = new System.Windows.Forms.Panel();
            this.compactCheckBox = new System.Windows.Forms.CheckBox();
            this.startStopCheckBox = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.topMostCheckBox = new System.Windows.Forms.CheckBox();
            this.transparentTrackBar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.consoleTextBox = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warningVoiceUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalUpDown)).BeginInit();
            this.toolBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transparentTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.serverDataGridView);
            this.mainSplitContainer.Panel1.Controls.Add(this.label6);
            this.mainSplitContainer.Panel1.Controls.Add(this.warningVoiceUpDown);
            this.mainSplitContainer.Panel1.Controls.Add(this.label3);
            this.mainSplitContainer.Panel1.Controls.Add(this.intervalUpDown);
            this.mainSplitContainer.Panel1.Controls.Add(this.voiceTextBox);
            this.mainSplitContainer.Panel1.Controls.Add(this.label1);
            this.mainSplitContainer.Panel1.Controls.Add(this.toolBarPanel);
            this.mainSplitContainer.Panel1.Controls.Add(this.label5);
            this.mainSplitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.consoleTextBox);
            this.mainSplitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainSplitContainer.Size = new System.Drawing.Size(746, 546);
            this.mainSplitContainer.SplitterDistance = 271;
            this.mainSplitContainer.TabIndex = 14;
            // 
            // serverDataGridView
            // 
            this.serverDataGridView.AllowUserToAddRows = false;
            this.serverDataGridView.AllowUserToDeleteRows = false;
            this.serverDataGridView.AllowUserToResizeRows = false;
            this.serverDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.serverDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serverDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pingThisServer,
            this.name,
            this.IP,
            this.TimeOut,
            this.CountForWarning,
            this.pingButton,
            this.PingFlag});
            this.serverDataGridView.Location = new System.Drawing.Point(0, 25);
            this.serverDataGridView.Name = "serverDataGridView";
            this.serverDataGridView.RowHeadersVisible = false;
            this.serverDataGridView.ShowCellToolTips = false;
            this.serverDataGridView.Size = new System.Drawing.Size(465, 242);
            this.serverDataGridView.TabIndex = 5;
            this.toolTip1.SetToolTip(this.serverDataGridView, "Двойной клик меняет вид окна");
            this.serverDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.serverDataGridView_CellClick);
            this.serverDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.serverDataGridView_DataError);
            this.serverDataGridView.DoubleClick += new System.EventHandler(this.serverDataGridView_DoubleClick);
            // 
            // pingThisServer
            // 
            this.pingThisServer.DataPropertyName = "PingThisServer";
            this.pingThisServer.Frozen = true;
            this.pingThisServer.HeaderText = "Пинг";
            this.pingThisServer.Name = "pingThisServer";
            this.pingThisServer.Width = 37;
            // 
            // name
            // 
            this.name.DataPropertyName = "ServerName";
            this.name.Frozen = true;
            this.name.HeaderText = "Сервер";
            this.name.Name = "name";
            // 
            // IP
            // 
            this.IP.DataPropertyName = "ServerIP";
            this.IP.Frozen = true;
            this.IP.HeaderText = "IP";
            this.IP.Name = "IP";
            // 
            // TimeOut
            // 
            this.TimeOut.DataPropertyName = "TimeOut";
            this.TimeOut.Frozen = true;
            this.TimeOut.HeaderText = "TimeOut";
            this.TimeOut.Name = "TimeOut";
            this.TimeOut.Width = 60;
            // 
            // CountForWarning
            // 
            this.CountForWarning.DataPropertyName = "CountForWarning";
            this.CountForWarning.Frozen = true;
            this.CountForWarning.HeaderText = "Пердупреждение";
            this.CountForWarning.Name = "CountForWarning";
            // 
            // pingButton
            // 
            this.pingButton.Frozen = true;
            this.pingButton.HeaderText = "Ping";
            this.pingButton.Name = "pingButton";
            this.pingButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pingButton.Text = "ping -t";
            this.pingButton.ToolTipText = "Открыть окно стандартного пинга";
            this.pingButton.UseColumnTextForButtonValue = true;
            this.pingButton.Width = 53;
            // 
            // PingFlag
            // 
            this.PingFlag.DataPropertyName = "PingFlag";
            this.PingFlag.HeaderText = "";
            this.PingFlag.Name = "PingFlag";
            this.PingFlag.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 156);
            this.label6.TabIndex = 28;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // warningVoiceUpDown
            // 
            this.warningVoiceUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.warningVoiceUpDown.Location = new System.Drawing.Point(561, 77);
            this.warningVoiceUpDown.Name = "warningVoiceUpDown";
            this.warningVoiceUpDown.Size = new System.Drawing.Size(37, 20);
            this.warningVoiceUpDown.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Голос";
            // 
            // intervalUpDown
            // 
            this.intervalUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.intervalUpDown.Location = new System.Drawing.Point(561, 29);
            this.intervalUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.intervalUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.intervalUpDown.Name = "intervalUpDown";
            this.intervalUpDown.Size = new System.Drawing.Size(46, 20);
            this.intervalUpDown.TabIndex = 16;
            this.intervalUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.intervalUpDown.ValueChanged += new System.EventHandler(this.intervalUpDown_ValueChanged);
            // 
            // voiceTextBox
            // 
            this.voiceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.voiceTextBox.Location = new System.Drawing.Point(561, 52);
            this.voiceTextBox.Name = "voiceTextBox";
            this.voiceTextBox.Size = new System.Drawing.Size(162, 20);
            this.voiceTextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(506, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Интервал                 сек";
            // 
            // toolBarPanel
            // 
            this.toolBarPanel.Controls.Add(this.compactCheckBox);
            this.toolBarPanel.Controls.Add(this.startStopCheckBox);
            this.toolBarPanel.Controls.Add(this.saveButton);
            this.toolBarPanel.Controls.Add(this.removeButton);
            this.toolBarPanel.Controls.Add(this.addButton);
            this.toolBarPanel.Controls.Add(this.topMostCheckBox);
            this.toolBarPanel.Controls.Add(this.transparentTrackBar);
            this.toolBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolBarPanel.Location = new System.Drawing.Point(0, 0);
            this.toolBarPanel.Name = "toolBarPanel";
            this.toolBarPanel.Size = new System.Drawing.Size(746, 25);
            this.toolBarPanel.TabIndex = 34;
            // 
            // compactCheckBox
            // 
            this.compactCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.compactCheckBox.Image = ((System.Drawing.Image)(resources.GetObject("compactCheckBox.Image")));
            this.compactCheckBox.Location = new System.Drawing.Point(156, 0);
            this.compactCheckBox.Name = "compactCheckBox";
            this.compactCheckBox.Size = new System.Drawing.Size(30, 25);
            this.compactCheckBox.TabIndex = 43;
            this.toolTip1.SetToolTip(this.compactCheckBox, "Компактный вид окна");
            this.compactCheckBox.UseVisualStyleBackColor = true;
            this.compactCheckBox.CheckedChanged += new System.EventHandler(this.compactCheckBox_CheckedChanged);
            // 
            // startStopCheckBox
            // 
            this.startStopCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.startStopCheckBox.Checked = true;
            this.startStopCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.startStopCheckBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.startStopCheckBox.Image = ((System.Drawing.Image)(resources.GetObject("startStopCheckBox.Image")));
            this.startStopCheckBox.Location = new System.Drawing.Point(98, 0);
            this.startStopCheckBox.Name = "startStopCheckBox";
            this.startStopCheckBox.Size = new System.Drawing.Size(30, 25);
            this.startStopCheckBox.TabIndex = 42;
            this.toolTip1.SetToolTip(this.startStopCheckBox, "Старт/Стоп");
            this.startStopCheckBox.UseVisualStyleBackColor = true;
            this.startStopCheckBox.CheckedChanged += new System.EventHandler(this.startStopCheckBox_CheckedChanged);
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.Location = new System.Drawing.Point(62, 0);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(31, 25);
            this.saveButton.TabIndex = 36;
            this.toolTip1.SetToolTip(this.saveButton, "Сохранить список серверов");
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.removeButton.Image = ((System.Drawing.Image)(resources.GetObject("removeButton.Image")));
            this.removeButton.Location = new System.Drawing.Point(31, 0);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(31, 25);
            this.removeButton.TabIndex = 35;
            this.toolTip1.SetToolTip(this.removeButton, "Удалить выбранный сервер");
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.Location = new System.Drawing.Point(0, 0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(31, 25);
            this.addButton.TabIndex = 34;
            this.toolTip1.SetToolTip(this.addButton, "Добавить сервер");
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // topMostCheckBox
            // 
            this.topMostCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.topMostCheckBox.Checked = true;
            this.topMostCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.topMostCheckBox.Image = ((System.Drawing.Image)(resources.GetObject("topMostCheckBox.Image")));
            this.topMostCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.topMostCheckBox.Location = new System.Drawing.Point(127, 0);
            this.topMostCheckBox.Name = "topMostCheckBox";
            this.topMostCheckBox.Size = new System.Drawing.Size(30, 25);
            this.topMostCheckBox.TabIndex = 39;
            this.toolTip1.SetToolTip(this.topMostCheckBox, "Поверх всех окон");
            this.topMostCheckBox.UseVisualStyleBackColor = true;
            this.topMostCheckBox.CheckedChanged += new System.EventHandler(this.topMostCheckBox_CheckedChanged);
            // 
            // transparentTrackBar
            // 
            this.transparentTrackBar.AutoSize = false;
            this.transparentTrackBar.Location = new System.Drawing.Point(184, 3);
            this.transparentTrackBar.Maximum = 100;
            this.transparentTrackBar.Minimum = 30;
            this.transparentTrackBar.Name = "transparentTrackBar";
            this.transparentTrackBar.Size = new System.Drawing.Size(154, 24);
            this.transparentTrackBar.TabIndex = 44;
            this.transparentTrackBar.TickFrequency = 5;
            this.transparentTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.toolTip1.SetToolTip(this.transparentTrackBar, "Прозрачность окна");
            this.transparentTrackBar.Value = 100;
            this.transparentTrackBar.Scroll += new System.EventHandler(this.transparentTrackBar_Scroll);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 26);
            this.label5.TabIndex = 23;
            this.label5.Text = "Количество\r\nпредупреждений";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.BackColor = System.Drawing.Color.Black;
            this.consoleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.consoleTextBox.ForeColor = System.Drawing.Color.White;
            this.consoleTextBox.Location = new System.Drawing.Point(0, 0);
            this.consoleTextBox.Multiline = true;
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleTextBox.Size = new System.Drawing.Size(746, 271);
            this.consoleTextBox.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Пингалятор";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // PingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 546);
            this.Controls.Add(this.mainSplitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(250, 260);
            this.Name = "PingForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пингалятор";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.pingForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel1.PerformLayout();
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serverDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warningVoiceUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalUpDown)).EndInit();
            this.toolBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transparentTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.NumericUpDown warningVoiceUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown intervalUpDown;
        private System.Windows.Forms.TextBox voiceTextBox;
        private System.Windows.Forms.DataGridView serverDataGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel toolBarPanel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.CheckBox topMostCheckBox;
        private System.Windows.Forms.CheckBox startStopCheckBox;
        private System.Windows.Forms.TrackBar transparentTrackBar;
        private System.Windows.Forms.CheckBox compactCheckBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox consoleTextBox;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pingThisServer;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountForWarning;
        private System.Windows.Forms.DataGridViewButtonColumn pingButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PingFlag;

    }
}

