using System.Net;

namespace BubbleBlower
{
    internal static class Program
    {
        public static string MksfoexPath = "./tools/vita-mksfoex.exe";
        public static string VitaPackPath = "./tools/vita-pack-vpk.exe";
        public static string SFOFilePath = "./tools/param.sfo";
        public static string TemplateFilePath = "./tools/template.xml";
        public static string EBootBinaryRelativePath = "./../../tools/eboot.bin";
        public static HttpClient HttpClient;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            HttpClient = new HttpClient();

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}