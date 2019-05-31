using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.Threading;

namespace gxv3240_mpk
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        public int global_i;
        public int global_len;
        List <gs_btn> btn_list;
        bool nextCliked;

        #region MPK
        private void click_addNewMPK()
        {
            webBrowser.Document.Window.Frames[0].Document.GetElementById("a_append").InvokeMember("click");
        }
        private void click_next()
        {
            webBrowser.Document.Window.Frames[0].Document.GetElementById("downpage").InvokeMember("click");
        }
        private void click_prev()
        {
            webBrowser.Document.Window.Frames[0].Document.GetElementById("uppage").InvokeMember("click");
        }
        private void input_name(string name)
        {
            webBrowser.Document.GetElementById("addname").SetAttribute("value", name);
        }
        private void input_userid(string userid)
        {
            webBrowser.Document.GetElementById("adduserid").SetAttribute("value", userid);
        }
        private void click_addok()
        {
            webBrowser.Document.GetElementById("a_addok").InvokeMember("click");
        }
        private void set_blf()
        {
            webBrowser.Document.GetElementById("addkeymode").SetAttribute("value", "1");
        }
        private void clear_mpk()
        {
            webBrowser.Document.Window.Frames[0].Document.GetElementById("t_check").InvokeMember("click");
            webBrowser.Document.Window.Frames[0].Document.GetElementById("all_del").InvokeMember("click");
            webBrowser.Document.Window.Frames[0].Document.GetElementById("jqi_state0_buttonOK").InvokeMember("click");
        }
        private void do_login(string login = "admin", string pass = "admin")
        {
            webBrowser.Document.GetElementById("username").SetAttribute("value", login);
            webBrowser.Document.GetElementById("password").SetAttribute("value", pass);
            webBrowser.Document.GetElementById("loginbtn").InvokeMember("click");
        }
        private void click_advset_menu()
        {
            webBrowser.Document.GetElementById("advset_menu").InvokeMember("click");
        }
        private void click_m_mpkextset1()
        {
            webBrowser.Document.GetElementById("m_mpkextset1").InvokeMember("click");
        }
        private string get_blf_from_page()
        {
            try
            {
                string js_gxv3240_get_mpk =
                    @"
	                    var name_arr = [];
	                    var userid_arr = [];
	                    var mode_arr = [];
	                    var to_return = '#mpk from page ' + document.getElementById('pagenum').innerText + '\r\n';
	                    var tmp_arr = document.querySelectorAll('.a_des');
	                    for (var i=0; i<tmp_arr.length; i++) {
		                    name_arr.push(tmp_arr[i].innerText);
	                    }
	                    var tmp_arr = document.querySelectorAll('.a_value');
	                    for (var i=0; i<tmp_arr.length; i++) {
		                    userid_arr.push(tmp_arr[i].innerText);
	                    }
	                    var tmp_arr = document.querySelectorAll('.a_mode');
	                    for (var i=0; i<tmp_arr.length; i++) {
		                    userid_arr.push(tmp_arr[i].innerText);
		                    if (tmp_arr[i].innerText == 'Busy Lamp Field (BLF)') {
			                    mode_arr.push('blf');
		                    }
		                    else {
			                    mode_arr.push('sd');
		                    }
	                    }
	                    for (var i=0; i<name_arr.length; i++) {
		                    to_return+=name_arr[i]+'\t'+userid_arr[i]+'\t'+mode_arr[i]+'\r\n';
	                    }
	                    var gxv3240_get_mpk_return = to_return;
                    ";
                HtmlDocument doc = webBrowser.Document.Window.Frames[0].Document;
                HtmlElement head = doc.GetElementsByTagName("head")[0];
                HtmlElement s = doc.CreateElement("script");
                s.SetAttribute("text", js_gxv3240_get_mpk);
                head.AppendChild(s);
                return doc.InvokeScript("eval", new object[] { "gxv3240_get_mpk_return" }).ToString();

            }
            catch
            {
                return "#error export mpk\r\n";
            }
        }
        #endregion


        #region ChekUpdate
        private string GetCurVersion()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            return fvi.FileVersion;
        }
        private void ChekUpdate()
        {
            WebClient versionChecker = new WebClient();
            versionChecker.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore);
            versionChecker.DownloadStringCompleted += new DownloadStringCompletedEventHandler(versionCheck);
            versionChecker.DownloadStringAsync(new Uri("https://raw.githubusercontent.com/riv-gh/gxv3240_mpk/master/version_date.txt"));
        }
        private string GeWikitPage()
        {
            WebClient wc = new WebClient();
            wc.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore);
            wc.DownloadStringCompleted += new DownloadStringCompletedEventHandler(versionCheck);
            return wc.DownloadString(new Uri("https://raw.githubusercontent.com/riv-gh/gxv3240_mpk/master/readme.html"));
        }

        private void wikiInBrowser(WebBrowser wb, string defaultHtml)
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

        private void versionCheck(object sender, DownloadStringCompletedEventArgs e)
        {
            if (e.Error != null)
                return;
            string availableVersion = e.Result.Trim();
            // MessageBox.Show(e.Result);
            if (availableVersion != GetCurVersion())
            {
                DialogResult dialogResult = MessageBox.Show($"Version {availableVersion} is available.\r\nOpen project page to download it?", "New version available ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Process.Start("https://github.com/riv-gh/gxv3240_mpk/releases");
                }
            }
            
        }
        #endregion

        #region test buttons
        private void btnTest1_Click(object sender, EventArgs e)
        {
            
            //timer1.Start();
        }
        private void btnTest2_Click(object sender, EventArgs e)
        {
            clear_mpk();
        }
        private void btnTest3_Click(object sender, EventArgs e)
        {
            gbTest.Hide();
        }
        private void btnTest4_Click(object sender, EventArgs e)
        {
            do_login();
        }
        private void btnTest5_Click(object sender, EventArgs e)
        {
            btn_list = new List<gs_btn>();
            string tmp_text = String.Empty;
            foreach (string tmp_str in tbMain.Lines)
            {
                string tmp = tmp_str.Trim();
                if (!((tmp.Length == 0) || (tmp[0] == '#')))
                {
                    try
                    {
                        string[] tmp_arr = tmp.Split('\t');
                        gs_btn tmp_btn = new gs_btn();
                        tmp_btn.name = tmp_arr[0];
                        tmp_btn.userid = tmp_arr[1];
                        tmp_btn.mode = (tmp_arr.Length < 3) ? "default" : tmp_arr[2];
                        btn_list.Add(tmp_btn);
                        //MessageBox.Show(tmp_btn.ToString());
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(String.Format("Error to add phone line:\r\n{0}\r\n\r\nError:{1}", tmp, err.ToString()));
                    }
                }
            }
            global_i = 0;
            global_len = btn_list.Count;
            nextCliked = false;
            timer2.Start();
        }
        #endregion

        #region timers
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                timer1.Stop();
                click_advset_menu();
                click_m_mpkextset1();
                timer3.Start();
            }
            catch { }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            btnGet.PerformClick();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            if ((global_i == 20) && (!nextCliked))
            {
                click_next();
                nextCliked = true;
            }
            if (global_i < global_len)
            {
                click_addNewMPK();
                input_name(btn_list[global_i].name);
                input_userid(btn_list[global_i].userid);
                if (btn_list[global_i].mode=="blf")
                {
                    set_blf();
                }
                click_addok();
                global_i++;
                timer2.Start();
                this.Text = String.Format("{0}/{1}", global_i, global_len);
            }
            else
            {
                this.Text = "complete!";
                MessageBox.Show("complete!");
            }
        }
        #endregion

        #region buttons
        private void tbMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A) tbMain.SelectAll();
        }
        private void btnNavigate_Click(object sender, EventArgs e)
        {
            if (cbUrl.Text.IndexOf("http://") != 0)
            {
                cbUrl.Text = "http://" + cbUrl.Text;
            }
            if (!cbUrl.Items.Contains(cbUrl.Text))
            {
                cbUrl.Items.Add(cbUrl.Text);
            }
            webBrowser.Navigate(cbUrl.Text);
        }
        private void cbUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnNavigate.PerformClick();
            }
        }
        private void btnTestBrowser_Click(object sender, EventArgs e)
        {
            webBrowser.DocumentText = Clipboard.GetText();
        }
        private void btnDoLogin_Click(object sender, EventArgs e)
        {
            try
            {
                do_login(tbLogin.Text, tbPass.Text);
            }
            catch
            {
                MessageBox.Show("fail, maybe loggedin\r\nor go to logon page and try again");
            }
            timer1.Start();
        }
        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                click_prev();
            }
            catch { }
            btnClear.PerformClick();
            btn_list = new List<gs_btn>();
            string tmp_text = String.Empty;
            foreach (string tmp_str in tbMain.Lines)
            {
                string tmp = tmp_str.Trim();
                if (!((tmp.Length == 0) || (tmp[0] == '#')))
                {
                    try
                    {
                        string[] tmp_arr = tmp.Split('\t');
                        gs_btn tmp_btn = new gs_btn();
                        tmp_btn.name = tmp_arr[0];
                        tmp_btn.userid = tmp_arr[1];
                        tmp_btn.mode = (tmp_arr.Length < 3) ? "default" : tmp_arr[2];
                        btn_list.Add(tmp_btn);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(String.Format("Error to add phone line:\r\n{0}\r\n\r\nError:{1}", tmp, err.ToString()));
                    }
                }
            }
            global_i = 0;
            global_len = btn_list.Count;
            nextCliked = false;
            timer2.Start();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                clear_mpk();
            }
            catch (Exception exc)
            {
                MessageBox.Show(String.Format("Error in cleaing MPK\r\nException:{0}", exc.ToString()));
            }
        }
        private void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    click_prev();
                }
                catch { }
                tbMain.Clear();
                tbMain.AppendText(get_blf_from_page());
                click_next();
                tbMain.AppendText(get_blf_from_page());
                click_prev();
            }
            catch (Exception exc)
            {
                MessageBox.Show(String.Format("Error in getting MPK from phone\r\nException:{0}", exc.ToString()));
            }
        }
        private void trackTimerDelay_Scroll(object sender, EventArgs e)
        {
            timer2.Interval = trackTimerDelay.Value * 500;
            lTimerDelay.Text = $"WriteMPK delay: {trackTimerDelay.Value*0.5}s";
        }
        #endregion

        #region load
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = $"{this.Text} [{GetCurVersion()}]";
            Thread threadChekUpdate = new Thread(ChekUpdate);
            threadChekUpdate.Start();
            Thread threadWikiInBrowser = new Thread(() => wikiInBrowser(webBrowser, tbBrowserSorce.Text));
            threadWikiInBrowser.Start();
            if (Properties.Settings.Default.urls.Length>0)
            {
                string[] tmp_url_arr = Properties.Settings.Default.urls.Split('|');
                for (int i = 0; i < tmp_url_arr.Length; i++)
                {
                    cbUrl.Items.Add(tmp_url_arr[i]);
                }     
            }

            //Properties.Settings.Default
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            webBrowser.DocumentText = @"
                <!DOCTYPE html>
                <html>
                <head>
                <meta http-equiv='Content-Type' content='text/html; charset=utf-8' />
                <style>
	                #preload {
		                text-align: center;
		                font-size: 120px;
		                color: #333;
	                }
                </style>
                </head>
                <body>
	                <div id='preload'></div>
                <script type='text/javascript'>
	                var preload = document.getElementById('preload');
	                preload.innerText = '...';
	                setInterval(function() {
		                preload.innerText = preload.innerText+'.';
		                if (preload.innerText.length>10) {
			                preload.innerText = '...';
		                }
	                },300);
                </script>
                </body>
                </html>
            ";
            
        }


        #endregion

        private void cbUrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbUrl.Text = cbUrl.Text;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Properties.Settings.Default.urls.Length > 0)
            {
                string tmp = "";
                for(int i=0; i<cbUrl.Items.Count; i++)
                {
                    if (tmp.Length == 0)
                    {
                        tmp = cbUrl.Items[i].ToString();
                    }
                    else
                    {
                        tmp += "|" + cbUrl.Items[i].ToString();
                    }
                }
                Properties.Settings.Default.urls = tmp;
                Properties.Settings.Default.Save();
            }
        }

        private void btnUrlClear_Click(object sender, EventArgs e)
        {
            cbUrl.Items.Clear();
        }
    }
}
