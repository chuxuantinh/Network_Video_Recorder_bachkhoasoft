using System;
using System.Drawing;
using System.Windows.Forms;
using Ozeki.Media.IPCamera;
using Ozeki.Media.MediaHandlers.Video;
using Ozeki.Media.Video.Controls;
using Ozeki.Media.MediaHandlers;
// chutinh - https://bachkhoasoft.com

namespace Network_Video_Recorder01
{
    public partial class Form1 : Form
    {
        private IIPCamera _camera;
        private DrawingImageProvider _imageProvider;
        private MediaConnector _connector;
        private VideoViewerWF _videoViewerWf;
        private MPEG4Recorder _mpeg4Recorder;

        public Form1()
        {
            InitializeComponent();
            _imageProvider = new DrawingImageProvider();
            _connector = new MediaConnector();
            _videoViewerWf = new VideoViewerWF();
            SetVideoViewer();
        }

        private void SetVideoViewer()
        {
            CameraBox.Controls.Add(_videoViewerWf);
            _videoViewerWf.Size = new Size(260, 180);
            _videoViewerWf.BackColor = Color.Black;
            _videoViewerWf.TabStop = false;
            _videoViewerWf.Location = new Point(14, 19);
            _videoViewerWf.Name = "_videoViewerWf";
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            _camera = IPCameraFactory.GetCamera("192.168.115.175:8080", "admin", "admin");
            _connector.Connect(_camera.VideoChannel, _imageProvider);
            _videoViewerWf.SetImageProvider(_imageProvider);
            _videoViewerWf.Start();
            _camera.Start();
        }

        private void Button_CaptureVideoStart_Click(object sender, EventArgs e)
        {
            var path = TextBox_SaveTo.Text;
            if (!String.IsNullOrEmpty(path))
                StartVideoCapture(path);
        }

        private void StartVideoCapture(string path)
        {
            var date = DateTime.Now.Year + "y-" + DateTime.Now.Month + "m-" + DateTime.Now.Day + "d-" +
                       DateTime.Now.Hour + "h-" + DateTime.Now.Minute + "m-" + DateTime.Now.Second + "s";
            string currentpath;
            if (String.IsNullOrEmpty(path))
                currentpath = date + ".mp4";
            else
                currentpath = path + "\\" + date + ".mp4";

            _mpeg4Recorder = new MPEG4Recorder(currentpath);
            _mpeg4Recorder.MultiplexFinished += Mpeg4Recorder_MultiplexFinished;
            _connector.Connect(_camera.AudioChannel, _mpeg4Recorder.AudioRecorder);
            _connector.Connect(_camera.VideoChannel, _mpeg4Recorder.VideoRecorder);
        }

        private void Mpeg4Recorder_MultiplexFinished(object sender, Ozeki.VoIP.VoIPEventArgs<bool> e)
        {
            _connector.Disconnect(_camera.AudioChannel, _mpeg4Recorder.AudioRecorder);
            _connector.Disconnect(_camera.VideoChannel, _mpeg4Recorder.VideoRecorder);
            _mpeg4Recorder.Dispose();
        }

        private void Button_CaptureVideoStop_Click(object sender, EventArgs e)
        {
            StopVideoCapture();
        }

        private void StopVideoCapture()
        {
            _mpeg4Recorder.Multiplex();
            _connector.Disconnect(_camera.AudioChannel, _mpeg4Recorder.AudioRecorder);
            _connector.Disconnect(_camera.VideoChannel, _mpeg4Recorder.VideoRecorder);
        }

        private void Button_SaveTo_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
                TextBox_SaveTo.Text = folderBrowserDialog1.SelectedPath;
        }
    }
}