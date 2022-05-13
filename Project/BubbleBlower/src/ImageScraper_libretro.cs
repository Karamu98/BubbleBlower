using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BubbleBlower
{
    internal class ImageScraper_libretro
    {
        public static readonly string Boxart = "Named_Boxarts";
        public static readonly string Screenshot = "Named_Snaps";
        public static readonly string Title = "Named_Titles";
        private static readonly string BaseURL = "http://thumbnails.libretro.com/";


        public static string? GetImageURLFromGame(string gameFile, string platform, string imageType = "Named_Boxarts")
        {
            string gameName = Path.GetFileNameWithoutExtension(gameFile);

            char[] badCharacters = new char[] { '&', '*', '/', ':', '`', '<', '>', '?', '\\', '|' };
            foreach(char character in badCharacters)
            {
                gameName = gameName.Replace(character, '_');
            }
            return $"{BaseURL}{platform}/{imageType}/{gameName}.png".Replace(" ", "%20");
        }
    }
}
