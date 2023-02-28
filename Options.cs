using AForge.Vision.Motion;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace PSS_Test2
{
    public partial class Options : Form
    {
        Window videoWindow;
        FolderBrowserDialog fbd;

        private string saveDirectory;

        //Initialize
        public Options(Window W)
        {
            InitializeComponent();

            videoWindow = W;
            fbd = new FolderBrowserDialog();

            Init();
        }

        //Select save directory button
        private void dirButton_Click(object sender, EventArgs e)
        {
            fbd.ShowDialog();

            saveDirectory = fbd.SelectedPath;
            dirLabel.Text = fbd.SelectedPath;
        }

        //When closes enable main window
        private void Option_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;

                videoWindow.Enabled = true;
                Hide();
            }

            ApplyOptions();
        }

        //Load settings from appconfig
        private void Init()
        {
            if (ConfigurationManager.AppSettings.Get("log") == "true") logCheckBox.Checked = true;
            else logCheckBox.Checked = false;

            if (ConfigurationManager.AppSettings.Get("photos") == "true") photoCheckBox.Checked = true;
            else photoCheckBox.Checked = false;

            if (ConfigurationManager.AppSettings.Get("highlights") == "true") highlightsCheckBox.Checked = true;
            else highlightsCheckBox.Checked = false;

            if (ConfigurationManager.AppSettings.Get("savedir") != "")
            {
                dirLabel.Text = ConfigurationManager.AppSettings.Get("savedir");
                saveDirectory = ConfigurationManager.AppSettings.Get("savedir");
            }
            ApplyOptions();
        }

        //Save settings to appconfig & apply them in real time
        private void ApplyOptions()
        {
            //Init for Window.cs
            videoWindow.log = logCheckBox.Checked;
            videoWindow.save = photoCheckBox.Checked;
            videoWindow.saveDirectory = saveDirectory;
            if (highlightsCheckBox.Checked) videoWindow.detector = new MotionDetector(new TwoFramesDifferenceDetector(), new MotionBorderHighlighting());
            else videoWindow.detector = new MotionDetector(new TwoFramesDifferenceDetector());


            //Save to .config
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (logCheckBox.Checked) configuration.AppSettings.Settings["log"].Value = "true";
            else configuration.AppSettings.Settings["log"].Value = "false";

            if (photoCheckBox.Checked) configuration.AppSettings.Settings["photos"].Value = "true";
            else configuration.AppSettings.Settings["photos"].Value = "false";

            if (highlightsCheckBox.Checked) configuration.AppSettings.Settings["highlights"].Value = "true";
            else configuration.AppSettings.Settings["highlights"].Value = "false";

            configuration.AppSettings.Settings["savedir"].Value = saveDirectory;

            configuration.Save(ConfigurationSaveMode.Full, true);
            ConfigurationManager.RefreshSection("appSettings");
        }

    }
}
