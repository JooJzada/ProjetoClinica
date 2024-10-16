using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ProjetoClinica.Utilidade
{
    public static class ConversorImagem
    {
        public static Image ConvertByteArrayToImg(byte[] data)
        {
            if (data[0] != 0)
            {
                using (MemoryStream ms = new MemoryStream(data))
                {
                    return Image.FromStream(ms);
                }
            }
            return null;
        }


        public static byte[] ConvertImgToByte(Image _img)
        {
            if (_img != null)
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    _img.Save(memoryStream, ImageFormat.Png);
                    return memoryStream.ToArray();
                }
            }

            return new byte[] { 0 };
        }
        
    }
}
