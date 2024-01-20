using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.login_button = new System.Windows.Forms.Button();
            this.pwd_textBox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.port_textBox = new System.Windows.Forms.TextBox();
            this.ip_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelU = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.save_button = new System.Windows.Forms.Button();
            this.comboBox_channel = new System.Windows.Forms.ComboBox();
            this.snap_button = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox_preview = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_preview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.login_button);
            this.panel1.Controls.Add(this.pwd_textBox);
            this.panel1.Controls.Add(this.name_textbox);
            this.panel1.Controls.Add(this.port_textBox);
            this.panel1.Controls.Add(this.ip_textBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelU);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 184);
            this.panel1.TabIndex = 0;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(53, 141);
            this.login_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(99, 32);
            this.login_button.TabIndex = 9;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // pwd_textBox
            // 
            this.pwd_textBox.Location = new System.Drawing.Point(83, 109);
            this.pwd_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pwd_textBox.Name = "pwd_textBox";
            this.pwd_textBox.Size = new System.Drawing.Size(149, 22);
            this.pwd_textBox.TabIndex = 8;
            this.pwd_textBox.Text = "admin123";
            this.pwd_textBox.UseSystemPasswordChar = true;
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(83, 78);
            this.name_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(149, 22);
            this.name_textbox.TabIndex = 7;
            this.name_textbox.Text = "admin";
            // 
            // port_textBox
            // 
            this.port_textBox.Location = new System.Drawing.Point(83, 49);
            this.port_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.port_textBox.Name = "port_textBox";
            this.port_textBox.Size = new System.Drawing.Size(149, 22);
            this.port_textBox.TabIndex = 6;
            this.port_textBox.Text = "37777";
            this.port_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.port_textBox_KeyPress);
            // 
            // ip_textBox
            // 
            this.ip_textBox.Location = new System.Drawing.Point(83, 20);
            this.ip_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ip_textBox.MaxLength = 16;
            this.ip_textBox.Name = "ip_textBox";
            this.ip_textBox.Size = new System.Drawing.Size(149, 22);
            this.ip_textBox.TabIndex = 5;
            this.ip_textBox.Text = "192.168.1.1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password :";
            // 
            // labelU
            // 
            this.labelU.AutoSize = true;
            this.labelU.Location = new System.Drawing.Point(9, 84);
            this.labelU.Name = "labelU";
            this.labelU.Size = new System.Drawing.Size(42, 16);
            this.labelU.TabIndex = 3;
            this.labelU.Text = "User :";
            this.labelU.Click += new System.EventHandler(this.labelU_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device Login";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.save_button);
            this.panel2.Controls.Add(this.comboBox_channel);
            this.panel2.Controls.Add(this.snap_button);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(8, 555);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 176);
            this.panel2.TabIndex = 10;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(136, 142);
            this.save_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(94, 32);
            this.save_button.TabIndex = 13;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            // 
            // comboBox_channel
            // 
            this.comboBox_channel.FormattingEnabled = true;
            this.comboBox_channel.Location = new System.Drawing.Point(79, 15);
            this.comboBox_channel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_channel.Name = "comboBox_channel";
            this.comboBox_channel.Size = new System.Drawing.Size(151, 24);
            this.comboBox_channel.TabIndex = 11;
            // 
            // snap_button
            // 
            this.snap_button.Location = new System.Drawing.Point(4, 142);
            this.snap_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.snap_button.Name = "snap_button";
            this.snap_button.Size = new System.Drawing.Size(94, 32);
            this.snap_button.TabIndex = 9;
            this.snap_button.Text = "Snap";
            this.snap_button.UseVisualStyleBackColor = true;
            this.snap_button.Click += new System.EventHandler(this.snap_button_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Channel :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Snapshot";
            // 
            // pictureBox_preview
            // 
            this.pictureBox_preview.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_preview.Location = new System.Drawing.Point(255, 11);
            this.pictureBox_preview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_preview.Name = "pictureBox_preview";
            this.pictureBox_preview.Size = new System.Drawing.Size(1280, 720);
            this.pictureBox_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_preview.TabIndex = 11;
            this.pictureBox_preview.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1542, 737);
            this.Controls.Add(this.pictureBox_preview);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Dahua SDK challenge";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_preview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button login_button;
        private TextBox pwd_textBox;
        private TextBox name_textbox;
        private TextBox port_textBox;
        private TextBox ip_textBox;
        private Label label5;
        private Label labelU;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button snap_button;
        private Label label9;
        private Label label10;
        private ComboBox comboBox_channel;
        private Button save_button;
        private PictureBox pictureBox_preview;
    }
}
