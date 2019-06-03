using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gxv3240_mpk
{
    public static class PropertiesSaver
    {
        public static void GetUrls(ComboBox cb)
        {
            if (Properties.Settings.Default.urls.Length > 0)
            {
                string[] tmp_url_arr = Properties.Settings.Default.urls.Split('|');
                for (int i = 0; i < tmp_url_arr.Length; i++)
                {
                    cb.Items.Add(tmp_url_arr[i]);
                }
            }
        }

        public static void SaveUrls(ComboBox cb)
        {
            if (Properties.Settings.Default.urls.Length > 0)
            {
                string tmp = "";
                for (int i = 0; i < cb.Items.Count; i++)
                {
                    if (tmp.Length == 0)
                    {
                        tmp = cb.Items[i].ToString();
                    }
                    else
                    {
                        tmp += "|" + cb.Items[i].ToString();
                    }
                }
                Properties.Settings.Default.urls = tmp;
                Properties.Settings.Default.Save();
            }
        }
        
    }
}
