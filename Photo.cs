using AForge.Controls;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace PSS_Test2
{
    public class Photo
    {
        public void CapturePhoto(VideoSourcePlayer vsp, string saveDirectory)
        {
            //Frame from video source player
            Bitmap frame = vsp.GetCurrentVideoFrame();

            //Save frame as jpg img
            string fileName = DateTime.Now.ToString("dd.MM.yyyy") + "_" + DateTime.Now.ToString("HH.mm.ss") + ".jpg";
            string filePath = Path.Combine(saveDirectory, fileName);

            if (Directory.Exists(saveDirectory)) frame.Save(filePath, ImageFormat.Jpeg);

            //Relase frame to save memory
            frame.Dispose();
        }

    }
}
