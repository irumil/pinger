using SpeechLib;
using System;
using System.Drawing;
using System.Windows.Forms;
using PingServersManager;

namespace PingServers
{
    public partial class PingForm : Form
    {
        private readonly ServerManager _serverManger;
        private WindowSettings _windowSettings;

        private void pingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _serverManger.PingProcessCompleted -= OnPingProcessComplete;    
            WriteConfigWindow();
        }

        public PingForm()
        {
            _serverManger= new ServerManager(true);

            _serverManger.PingProcessCompleted += OnPingProcessComplete;
            _serverManger.PingTimeOutEvent += OnPingTimeOut;
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadConfigWindow();  
             
            SetTransparentWindow(_windowSettings.Transparent);
            ChangeViewWindow(compactCheckBox.Checked);

            serverDataGridView.DataSource = _serverManger.GetServerList();
        }

        public void LoadConfigWindow()
        {
            try
            {
                intervalUpDown.Value = _serverManger.IntervalTimer;
              
                _windowSettings  = WindowSettings.GetSettings();
                transparentTrackBar.Value = _windowSettings.Transparent;
                Left = _windowSettings.Left;
                Top = _windowSettings.Top;
                Width = _windowSettings.Width;
                Height = _windowSettings.Height;
                voiceTextBox.Text = _windowSettings.VoiceText;
                warningVoiceUpDown.Value = _windowSettings.CountVoiceWarning;
                compactCheckBox.Checked = _windowSettings.IsCompact;
            }
            catch
            {
                MessageBox.Show("Ошибка загрузки настроек программы");
            }
        }
        
        private void WriteConfigWindow()
        {
            try
            {
                _windowSettings.Transparent=transparentTrackBar.Value;
                _windowSettings.Left = Left;
                _windowSettings.Top = Top;
                _windowSettings.Width = Width;
                _windowSettings.Height = Height;
                _windowSettings.VoiceText = voiceTextBox.Text;
                _windowSettings.CountVoiceWarning = (int)warningVoiceUpDown.Value;
                _windowSettings.IsCompact = compactCheckBox.Checked;
                _windowSettings.Save();
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения настроек");
            }
        }

        private void OnPingProcessComplete(string info)
        {
            Action<string> action = AppendInfoPing;
            if (InvokeRequired)
            {
                Invoke(action, info);
            }
            else
            {
                action(info);
            }
           
            SetColorForGrid();
        }

        private void SetColorForGrid()
        {
            if (serverDataGridView.Rows.Count == 0) return;

            foreach (DataGridViewRow row in serverDataGridView.Rows)
            {
               if (
                   (row.Cells["PingThisServer"].Value!= null)  && 
                   (bool)row.Cells["PingThisServer"].Value
                   )
                  SetColorGridRow(row, (bool)row.Cells["pingFlag"].Value);
            }
        }

        private void SetColorGridRow(DataGridViewRow gridRow, bool pingStatus)
        {
            gridRow.DefaultCellStyle.BackColor = (pingStatus) ? Color.Lime : Color.Red;
        }

        public void OnPingTimeOut(string serverName)
        {
            SpVoice speech = new SpVoice();

            for (int i=0; i<(int)warningVoiceUpDown.Value; i++) 
            {
               speech.Speak(string.Format("{0} {1}",serverName, voiceTextBox.Text), SpeechVoiceSpeakFlags.SVSFlagsAsync); 
            }
        }
        
        private void AppendInfoPing(string info)
        {
            consoleTextBox.AppendText(info);
        }

        public void OpenWindowsPing(string serverIp)
        {
            System.Diagnostics.Process.Start("ping.exe ",serverIp+" -t");
        }

        private void serverDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            if (dataGridView != null && dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                OpenWindowsPing(dataGridView.CurrentRow.Cells["IP"].Value.ToString());
            }
        }

        private void intervalUpDown_ValueChanged(object sender, EventArgs e)
        {
            _serverManger.IntervalTimer=(int)intervalUpDown.Value;
        }

        private void ChangeViewWindow(bool isCompact)
        {
            if (isCompact) SetCompactWindow();
            else SetFullWindow();
        }

        private void SetCompactWindow()
        {
            Width = serverDataGridView.Width + 25;
            Height = serverDataGridView.Height + 25;
            serverDataGridView.Dock = DockStyle.Fill;
            mainSplitContainer.Panel2Collapsed = true;
            toolBarPanel.Visible = false;
        }

        private void SetFullWindow()
        {
            Width = 770;
            Height = 600;
            serverDataGridView.Dock = DockStyle.Left;
            serverDataGridView.Anchor = (AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top);

            mainSplitContainer.Panel2Collapsed = false;
            toolBarPanel.Visible = true;
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            _serverManger.AddServer();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _serverManger.SaveServerList();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message); 
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Подтвердите удаление сервера из списка", "Удаление",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if ((result == DialogResult.Yes) && (serverDataGridView.CurrentRow != null))
                {
                    _serverManger.RemoveServer(serverDataGridView.CurrentRow.Index);
                }
            }
            catch
            {
                MessageBox.Show("Укажите что удалить!!!");
            }
        }

        private void SetTransparentWindow(int value)
        {
            Opacity = (double)value / 100;
        }

        private void serverDataGridView_DoubleClick(object sender, EventArgs e)
        {
            ChangeViewWindow(!compactCheckBox.Checked);
            compactCheckBox.Checked = !compactCheckBox.Checked;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TopMost = true;
            topMostCheckBox.Checked= TopMost;
        }

        private void transparentTrackBar_Scroll(object sender, EventArgs e)
        {
            SetTransparentWindow(transparentTrackBar.Value);
        }

        private void topMostCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = topMostCheckBox.Checked;
        }

        private void compactCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ChangeViewWindow(compactCheckBox.Checked);
        }

        private void startStopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _serverManger.StartStop();   
        }

        private void serverDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //
        }
    }
}
