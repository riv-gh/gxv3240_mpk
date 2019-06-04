using System;
using System.Windows.Forms;
using System.Net;

namespace gxv3240_mpk
{
    public static class WikiLoader
    {
        //public static string releases_link = "https://github.com/riv-gh/gxv3240_mpk/releases";
        //public static string version_date_link = "https://raw.githubusercontent.com/riv-gh/gxv3240_mpk/master/version_date.txt";
        public static string readme_link = "https://raw.githubusercontent.com/riv-gh/gxv3240_mpk/master/readme.html";

        //public static string GetCurVersion()
        //{
        //    System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
        //    FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
        //    return fvi.FileVersion;
        //}
        //public static void ChekUpdate()
        //{
        //    WebClient versionChecker = new WebClient();
        //    versionChecker.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore);
        //    versionChecker.DownloadStringCompleted += new DownloadStringCompletedEventHandler(versionCheck);
        //    versionChecker.DownloadStringAsync(new Uri(version_date_link));
        //}
        private static string GeWikitPage()
        {
            WebClient wc = new WebClient();
            wc.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore);
            //wc.DownloadStringCompleted += new DownloadStringCompletedEventHandler(versionCheck);
            return wc.DownloadString(new Uri(readme_link));
        }

        public static void wikiInBrowser(WebBrowser wb, string defaultHtml)
        {
            try
            {
                wb.DocumentText = GeWikitPage();
            }
            catch
            {
                wb.DocumentText = defaultHtml;
            }
        }

        //public static void versionCheck(object sender, DownloadStringCompletedEventArgs e)
        //{
        //    if (e.Error != null)
        //        return;
        //    string availableVersion = e.Result.Trim();
        //    if (availableVersion != GetCurVersion())
        //    {
        //        DialogResult dialogResult = MessageBox.Show($"Version {availableVersion} is available.\r\nOpen project page to download it?", "New version available ", MessageBoxButtons.YesNo);
        //        if (dialogResult == DialogResult.Yes)
        //        {
        //            Process.Start(releases_link);
        //        }
        //    }

        //}
    }
}
