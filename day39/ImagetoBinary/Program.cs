using ImagetoBinary.Models;
using System.Drawing;

namespace ImagetoBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Image image = Image.FromFile("C:\\RRD_Training\\Data\\sample1.Jpg");
            Models.ImageConverter app = new Models.ImageConverter();
            byte[] Imagedata = app.imageToByteArray(image);
            Console.WriteLine("Image Conversion is completed");

            app.byteArrayToImage(Imagedata);

            Console.WriteLine("Image generated at path ->C:\\RRD_Training\\Data\\Output\\");
        }
    }
}
