using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSACH
{
    class LopDungChung
    {

        public static Image byteSangAnh(byte[] byteArr)
        {
            MemoryStream ms = new MemoryStream(byteArr);
            return Image.FromStream(ms);
        }

        public static byte[] anhSangByte(Image hinhAnh)
        {
            MemoryStream ms = new MemoryStream();
            hinhAnh.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            return ms.ToArray();
        }

    }
}
