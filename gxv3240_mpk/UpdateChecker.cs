using System;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Windows.Forms;

namespace gxv3240_mpk
{
    static class UpdateChecker
    {
        public static string releasesWebLink = "https://github.com/riv-gh/gxv3240_mpk/releases";
        public static string releasesApiLink = "https://api.github.com/repos/riv-gh/gxv3240_mpk/releases";

        public static string GetCurVersion()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            return fvi.FileVersion;
        }
        private static string GetReleaseJson()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            WebClient wc = new WebClient();
            wc.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore);
            wc.Headers["User-Agent"] = "request";
            return wc.DownloadString(new Uri(releasesApiLink));
        }
        private static string[] GetVersionsTags(string json)
        {
            List<string> versions = new List<string>();
            Regex regex = new Regex("\"tag_name\":\"\\d{2}.\\d{2}.\\d{2}.\\d{1}");
            MatchCollection matches = regex.Matches(json);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    versions.Add(match.Value.Substring(12));
                }
                    
            }
            else { }
            string[] to_return = versions.ToArray();
            Array.Sort(to_return, (a, b) => -a.CompareTo(b));
            return to_return;
        }
        public static int ThisVersionPosition()
        {
            return Array.IndexOf(GetVersionsTags(GetReleaseJson()), GetCurVersion());
        }
        public static void ChekUpdate()
        {
            int thisVersionPosition = ThisVersionPosition();
            if (thisVersionPosition != 0)
            {
                DialogResult dialogResult = MessageBox.Show(
                    ( thisVersionPosition!=-1 ? $"{thisVersionPosition} version(s) is available." : "New version(s) is available") +
                    "\r\nOpen project page to download?",
                    "New version available",
                    MessageBoxButtons.YesNo
                );
                if (dialogResult == DialogResult.Yes)
                {
                    Process.Start(releasesWebLink);
                }
            }
        }
    }
}
