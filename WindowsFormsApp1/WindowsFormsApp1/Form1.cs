using NetSDKCS;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {


        private IntPtr _LoginID = IntPtr.Zero;
        private IntPtr _PlayID = IntPtr.Zero;
        private int _snapped = 0;
        private fSnapRevCallBack _SnapRevCallBack;
        private NET_DEVICEINFO_Ex _DeviceInfo = new NET_DEVICEINFO_Ex();
        private bool _IsSpanCapture = false;
        private DateTime m_DateTimeNow;
        public Form1()
        {
            InitializeComponent();
            try
            {
                //_SnapRevCallBack = new fSnapRevCallBack(SnapRevCallBack);
                NETClient.Init(null, IntPtr.Zero, null);
                NETClient.SetSnapRevCallBack(_SnapRevCallBack, IntPtr.Zero);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Process.GetCurrentProcess().Kill();
            }
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitOrLogoutUI();
        }

        private void InitOrLogoutUI()
        {
            login_button.Text = "Login";
            snap_button.Enabled = false;
            save_button.Enabled = false;
            comboBox_channel.Enabled = false;
            comboBox_channel.Items.Clear();
            this.pictureBox_preview.Image = null;
            pictureBox_preview.Refresh();

        }




        private void login_button_Click(object sender, EventArgs e)
        {

            if (IntPtr.Zero == _LoginID)
            {
                ushort port = 0;
                try
                {
                    port = Convert.ToUInt16(this.port_textBox.Text.Trim());
                }
                catch
                {
                    MessageBox.Show("Input port error");
                    return;
                }
                _LoginID = NETClient.LoginWithHighLevelSecurity(this.ip_textBox.Text.Trim(), port, this.name_textbox.Text.Trim(), this.pwd_textBox.Text, EM_LOGIN_SPAC_CAP_TYPE.TCP, IntPtr.Zero, ref _DeviceInfo);
                if (IntPtr.Zero == _LoginID)
                {
                    MessageBox.Show(NETClient.GetLastError());
                    return;
                }
                for (int i = 0; i < _DeviceInfo.nChanNum; i++)
                {
                    this.comboBox_channel.Items.Add(i + 1);
                }
                this.comboBox_channel.SelectedIndex = 0;
                this.comboBox_channel.Enabled = true;
                this.snap_button.Enabled = true;
                this.login_button.Text = "Logout";
                this.pictureBox_preview.Refresh();
                this.startplay();

            }
            else
            {
                NETClient.Logout(_LoginID);
                _LoginID = IntPtr.Zero;
                this.InitOrLogoutUI();
            }
        }
        private void startplay()
        {
            if (IntPtr.Zero == _PlayID)
            {
                _PlayID = NETClient.RealPlay(_LoginID, comboBox_channel.SelectedIndex, this.pictureBox_preview.Handle);
                if (IntPtr.Zero == _PlayID)
                {
                    MessageBox.Show(NETClient.GetLastError());
                    return;
                }
            }
            else
            {
                NETClient.StopRealPlay(_PlayID);
                _PlayID = IntPtr.Zero;
                this.pictureBox_preview.Image?.Dispose();
                this.pictureBox_preview.Refresh();

            }
        }

        private void snap_button_Click(object sender, EventArgs e)
        {
            if (_snapped == 0)
            {
                
                if (pictureBox_preview.Image != null)
                {
                    pictureBox_preview.Image.Dispose();
                }
                string path = AppDomain.CurrentDomain.BaseDirectory + "image";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                DateTime now = DateTime.Now;
                string filePath = path + "\\" + string.Format("{0}-{1}-{2}-{3}-{4}-{5}", now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second) + ".jpg";
                string filePath2 = path + "\\" + string.Format("{0}-{1}-{2}-{3}-{4}-{5}", now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second+1) + ".jpg";
                bool ret = NETClient.CapturePicture(_PlayID, filePath, EM_NET_CAPTURE_FORMATS.JPEG);
                Thread.Sleep(1000);
                bool ret2 = NETClient.CapturePicture(_PlayID, filePath2, EM_NET_CAPTURE_FORMATS.JPEG);
                if (!ret || !ret2)
                {
                    MessageBox.Show(NETClient.GetLastError());
                    return;
                }
                Image image = Image.FromFile(filePath);
                NETClient.StopRealPlay(_PlayID);
                _PlayID = IntPtr.Zero;
                //this.pictureBox_preview.Refresh();
                pictureBox_preview.Image = image;
                MessageBox.Show("Pictures saved!");
                snap_button.Text = "Resume";
                _snapped = 1;
            }
            else
            {
                snap_button.Text = "Snap";
                startplay();
                _snapped = 0;
            }
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            NETClient.Cleanup();
        }

        private void port_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void labelU_Click(object sender, EventArgs e)
        {

        }
    }
}
