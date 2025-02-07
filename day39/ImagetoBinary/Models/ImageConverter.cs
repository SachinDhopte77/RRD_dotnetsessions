using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

using Image = System.Drawing.Image;

namespace ImagetoBinary.Models
{
    internal class ImageConverter
    {
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        public void byteArrayToImage(byte[] byteArray)
        {
            int halfLength;
            if (byteArray.Length % 2 == 0) { halfLength = byteArray.Length / 2; }
            else halfLength = (byteArray.Length + 1) / 2;
            byte[] imageBytes = new byte[byteArray.Length];
            for (int i = 0; i < byteArray.Length; i++)
            {
                if (i == halfLength)
                {
                    break;
                }
                imageBytes[i] = byteArray[i];

            }
            MemoryStream ms = new MemoryStream(imageBytes);
            Image returnImage = Image.FromStream(ms);
            returnImage.Save("C:\\RRD_Training\\Data\\Output\\Image.jpg", ImageFormat.Jpeg);
        }

        //public void byteArrayToImage2(byte[] byteArrayIn)
        //{
        //    MemoryStream ms = new MemoryStream(byteArrayIn);
        //    Image returnImage = Image.FromStream(ms);
        //    returnImage.Save("C:\\RRD_Training\\Data\\Output\\Image.jpg", ImageFormat.Jpeg);
        //}
    }
}
