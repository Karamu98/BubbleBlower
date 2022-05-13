using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleBlower
{
    [System.Serializable]
    public class PlatformSettings
    {
        public string[]? Extensions;
        public string? PSVitaROMDirectory;
        public string? DefaultIconPath;
        public string? DefaultBackgroundPath;
        public string? DefaultStartupPath;
        public string? IconHTMLResource;
        public string? BackgroundHTMLResource;
        public string? StartupHTMLResource;
        public string? Core;
        public bool? SanitiseGameName;
        public bool? AlwaysDefaultIcon;
        public bool? AlwaysDefaultBackground;
        public bool? AlwaysDefaultStart;
    }
}
