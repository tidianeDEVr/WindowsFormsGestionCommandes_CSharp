using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace WindowsFormsGestionCommandes.utils
{
    public class MyImage
    {
        public static byte[] convertImageToByte(string fileName)
        {
            Image image = Image.FromFile(fileName);
            MemoryStream stream = new MemoryStream();
            image.Save(stream, ImageFormat.Png);
            return stream.ToArray();
        }

        public static Image convertByteToImage(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            return Image.FromStream(stream);
        }

    }
}
