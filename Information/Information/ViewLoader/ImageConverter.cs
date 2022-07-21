using System.Drawing;
using System.IO;

namespace Information.ViewLoader
{
    public static class ImageConverter
    {
        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn);
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
            catch
            {
                Bitmap bitmap = new Bitmap(0,0);
                return bitmap;
            }
        }
    }
}
