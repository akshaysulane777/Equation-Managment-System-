using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace StudentManagement.Utilities
{
    public class ImageManipulations
    {
        // Byte[]

        public static byte[] GetPhoto(PictureBox pb)
        {
            MemoryStream ms = new MemoryStream();
            pb.Image.Save(ms, pb.Image.RawFormat);
            return ms.GetBuffer();
        }


        public static Image PutPhoto(Byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);

            return Image.FromStream(ms);
        }
    }
}
