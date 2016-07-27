/// <summary>
/// Program Author  :   Erkan ESEN (Esen Software And Design)
/// Created Date    :   2016.07.11 22:36
/// Revision Date   :   2016.07.11 22:36
/// Description     :   Bu Program *.* Dosyaların Shell Context Menüsüne Eklenir.
///                     Tıkladığında Seçili Olan Tüm Dosyaların Adreslerini Argüman Olarak Alır.
///                     Dosya ile Aynı Dizine Aynı Dosya İsmi ile Text Dökümanı Oluşturur ve
///                     Text Dökümanına Veri Girilmek Üzere Açar.
/// Communication   :   erkanesen2202@gmail.com
///                 :   27.07.2016 Added SourceControl
/// </summary>

using System;
using System.IO;
using System.Windows.Forms;

namespace TextNote
{
    static class Program
    {

        public static string filePath;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(String[] arguments)
        {
            if (arguments.Length > 0)
            {
                // Adres argumanını regtistry den alır
                filePath = arguments[0];

                // seçilen dosya ismi ile .txt dosyası varmı
                if (!File.Exists(filePath.Replace(Path.GetExtension(filePath), "") + ".txt"))
                {
                    // yok ise dosyayı oluştur.
                    File.Create(filePath.Replace(Path.GetExtension(filePath), "") + ".txt");
                }
                // .txt dosyasını aç
                System.Diagnostics.Process.Start(filePath.Replace(Path.GetExtension(filePath), "") + ".txt");
            }
            else
            {
                // adres argumanı gelmedi ise:
                MessageBox.Show("Dosya Seçilmedi || Not Selected File");
            }
        }
    }
}
