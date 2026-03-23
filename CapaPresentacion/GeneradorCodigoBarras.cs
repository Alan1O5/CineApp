using System;
using System.Drawing;
using System.IO;
using ZXing;

namespace CapaPresentacion
{
    public class GeneradorCodigoBarras
    {
        // Tu método original para mostrar en pantalla
        public static Bitmap Generar(string codigo)
        {
            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.CODE_128;
            writer.Options = new ZXing.Common.EncodingOptions { Width = 300, Height = 100 };
            return writer.Write(codigo);
        }

        // NUEVO: Método para convertir el Bitmap a bytes para la BD
        public static byte[] GenerarBytes(string codigo)
        {
            using (Bitmap bmp = Generar(codigo))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    // Guardamos el bitmap en el stream en formato PNG
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return ms.ToArray();
                }
            }
        }
    }
}