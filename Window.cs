using AForge.Video.DirectShow;
using AForge.Vision.Motion;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PSS_Test2
{
    public partial class Window : Form
    {
        private Form optionForm;

        public bool log;
        public bool save;
        public bool highlights;
        public string saveDirectory;

        private ExecutionState program = ExecutionState.Terminated;
        private ExecutionState capture = ExecutionState.Terminated;

        public MotionDetector detector;
        FilterInfoCollection devices;
        VideoCaptureDevice camera;
        float detectionLevel;

        Photo photo;

        //State
        public enum ExecutionState
        {
            Running,
            Terminated,
            Idle
        }

        //Init
        public Window()
        {
            InitializeComponent();

            camera = new VideoCaptureDevice();
            photo = new Photo();
        }



        //setup the videocapture
        private void Window_Load(object sender, EventArgs e)
        {
            detector = new MotionDetector(new TwoFramesDifferenceDetector());
            detectionLevel = 0;

            devices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo d in devices)
            {
                comboBox1.Items.Add(d.Name);
            }
            comboBox1.SelectedIndex = 0;

            optionForm = new Options(this);
        }

        //Turn off everything when closing window
        private void Window_FormClosing(object sender, FormClosingEventArgs e) //Terminate on closing
        {
            if (camera.IsRunning == true)
            {
                detectionLevel = 0;
                videoSourcePlayer1.SignalToStop();
                camera.Stop();
            }
        }

        //video
        private void videoSourcePlayer1_NewFrame(object sender, ref Bitmap image)
        {
            detectionLevel = detector.ProcessFrame(image);
        }



        //Start/Stop video motion detectiom
        private void videoButton_Click(object sender, EventArgs e)
        {
            if (program == ExecutionState.Terminated)
            {
                program = ExecutionState.Running;

                if (camera.IsRunning == true) camera.Stop();

                camera = new VideoCaptureDevice(devices[comboBox1.SelectedIndex].MonikerString);
                videoSourcePlayer1.VideoSource = camera;
                videoSourcePlayer1.Start();

                videoButton.Text = "Terminate";
                videoButton.ForeColor = Color.Red;
            }
            else
            {
                program = ExecutionState.Terminated;

                detectionLevel = 0;
                videoSourcePlayer1.SignalToStop();
                camera.Stop();

                videoButton.Text = "Execute";
                videoButton.ForeColor = Color.LimeGreen;
            }

        }

        //Record movement
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (detectionLevel > 0 && capture == ExecutionState.Running) //If movement is detected and turned on with btn
            {
                if (log) //Logging checkbox selected
                {
                    motionLog.Items.Add(System.DateTime.Now.ToString("HH:mm:ss") + " Motion Detected");
                    ScrollToBottom(motionLog);
                }
                if (save && saveDirectory != null) //Save scrnshots checkbox selected
                {
                    photo.CapturePhoto(videoSourcePlayer1, saveDirectory);
                }

            }
        }



        //Tunr on/off capturing
        private void captureButton_Click(object sender, EventArgs e)
        {
            if (capture == ExecutionState.Terminated)
            {
                capture = ExecutionState.Running;
                captureButton.Text = "Capture ON";
            }
            else
            {
                capture = ExecutionState.Terminated;
                captureButton.Text = "Capture OFF";
            }
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            optionForm.Show();
            this.Enabled = false;
        }


        #region Scroll To Bottom Function
        private const int WM_VSCROLL = 0x115;
        private const int SB_BOTTOM = 7;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

        private void ScrollToBottom(ListBox listBox)
        {
            SendMessage(listBox.Handle, WM_VSCROLL, (IntPtr)SB_BOTTOM, IntPtr.Zero);
        }
        #endregion

    }
}
