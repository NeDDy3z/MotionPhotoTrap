using System.Configuration;

namespace PSS_Test2
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.dirButton = new System.Windows.Forms.Button();
            this.logCheckBox = new System.Windows.Forms.CheckBox();
            this.photoCheckBox = new System.Windows.Forms.CheckBox();
            this.dirLabel = new System.Windows.Forms.Label();
            this.highlightsCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // dirButton
            // 
            this.dirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dirButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.dirButton.Location = new System.Drawing.Point(17, 55);
            this.dirButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dirButton.Name = "dirButton";
            this.dirButton.Size = new System.Drawing.Size(250, 29);
            this.dirButton.TabIndex = 0;
            this.dirButton.Text = "Choose screenshot directory";
            this.dirButton.UseVisualStyleBackColor = true;
            this.dirButton.Click += new System.EventHandler(this.dirButton_Click);
            // 
            // logCheckBox
            // 
            this.logCheckBox.AutoSize = true;
            this.logCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.logCheckBox.ForeColor = System.Drawing.Color.White;
            this.logCheckBox.Location = new System.Drawing.Point(17, 16);
            this.logCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logCheckBox.Name = "logCheckBox";
            this.logCheckBox.Size = new System.Drawing.Size(58, 24);
            this.logCheckBox.TabIndex = 1;
            this.logCheckBox.Text = "Log";
            this.logCheckBox.UseVisualStyleBackColor = true;
            // 
            // photoCheckBox
            // 
            this.photoCheckBox.AutoSize = true;
            this.photoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.photoCheckBox.ForeColor = System.Drawing.Color.White;
            this.photoCheckBox.Location = new System.Drawing.Point(82, 16);
            this.photoCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.photoCheckBox.Name = "photoCheckBox";
            this.photoCheckBox.Size = new System.Drawing.Size(84, 24);
            this.photoCheckBox.TabIndex = 2;
            this.photoCheckBox.Text = "Photos";
            this.photoCheckBox.UseVisualStyleBackColor = true;
            // 
            // dirLabel
            // 
            this.dirLabel.AutoSize = true;
            this.dirLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.dirLabel.ForeColor = System.Drawing.Color.Gray;
            this.dirLabel.Location = new System.Drawing.Point(14, 99);
            this.dirLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dirLabel.Name = "dirLabel";
            this.dirLabel.Size = new System.Drawing.Size(125, 13);
            this.dirLabel.TabIndex = 3;
            this.dirLabel.Text = "Directory not chosen";
            // 
            // highlightsCheckBox
            // 
            this.highlightsCheckBox.AutoSize = true;
            this.highlightsCheckBox.Checked = true;
            this.highlightsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.highlightsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.highlightsCheckBox.ForeColor = System.Drawing.Color.White;
            this.highlightsCheckBox.Location = new System.Drawing.Point(170, 16);
            this.highlightsCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.highlightsCheckBox.Name = "highlightsCheckBox";
            this.highlightsCheckBox.Size = new System.Drawing.Size(108, 24);
            this.highlightsCheckBox.TabIndex = 4;
            this.highlightsCheckBox.Text = "Highlights";
            this.highlightsCheckBox.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(285, 126);
            this.Controls.Add(this.highlightsCheckBox);
            this.Controls.Add(this.dirLabel);
            this.Controls.Add(this.photoCheckBox);
            this.Controls.Add(this.logCheckBox);
            this.Controls.Add(this.dirButton);
            this.ForeColor = System.Drawing.SystemColors.Menu;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Option_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dirButton;
        private System.Windows.Forms.CheckBox logCheckBox;
        private System.Windows.Forms.CheckBox photoCheckBox;
        private System.Windows.Forms.Label dirLabel;
        private System.Windows.Forms.CheckBox highlightsCheckBox;
    }
}