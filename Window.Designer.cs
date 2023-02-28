using AForge.Imaging;
using System.Drawing;
using System.Windows.Forms;

namespace PSS_Test2
{
    partial class Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.videoButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.optionsButton = new System.Windows.Forms.Button();
            this.captureButton = new System.Windows.Forms.Button();
            this.motionLog = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.BorderColor = System.Drawing.Color.White;
            this.videoSourcePlayer1.Location = new System.Drawing.Point(17, 16);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(800, 439);
            this.videoSourcePlayer1.TabIndex = 10;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            this.videoSourcePlayer1.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer1_NewFrame);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 20;
            this.comboBox1.Location = new System.Drawing.Point(160, 471);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(335, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // videoButton
            // 
            this.videoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.videoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.videoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.videoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.videoButton.ForeColor = System.Drawing.Color.Green;
            this.videoButton.Location = new System.Drawing.Point(17, 471);
            this.videoButton.Margin = new System.Windows.Forms.Padding(0);
            this.videoButton.Name = "videoButton";
            this.videoButton.Size = new System.Drawing.Size(127, 29);
            this.videoButton.TabIndex = 1;
            this.videoButton.Text = "Execute";
            this.videoButton.UseVisualStyleBackColor = false;
            this.videoButton.Click += new System.EventHandler(this.videoButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // optionsButton
            // 
            this.optionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.optionsButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.optionsButton.Location = new System.Drawing.Point(963, 471);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(85, 28);
            this.optionsButton.TabIndex = 11;
            this.optionsButton.Text = "Options";
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // captureButton
            // 
            this.captureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.captureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.captureButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.captureButton.Location = new System.Drawing.Point(833, 471);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(124, 28);
            this.captureButton.TabIndex = 12;
            this.captureButton.Text = "Capture OFF";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // motionLog
            // 
            this.motionLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.motionLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.motionLog.ForeColor = System.Drawing.SystemColors.Menu;
            this.motionLog.FormattingEnabled = true;
            this.motionLog.IntegralHeight = false;
            this.motionLog.ItemHeight = 20;
            this.motionLog.Location = new System.Drawing.Point(833, 16);
            this.motionLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.motionLog.Name = "motionLog";
            this.motionLog.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.motionLog.Size = new System.Drawing.Size(215, 440);
            this.motionLog.TabIndex = 13;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1062, 515);
            this.Controls.Add(this.motionLog);
            this.Controls.Add(this.captureButton);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.videoButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.videoSourcePlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motion Detection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Window_FormClosing);
            this.Load += new System.EventHandler(this.Window_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button videoButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.ListBox motionLog;
    }
}