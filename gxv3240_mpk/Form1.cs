using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.Threading;
using System.Xml.Linq;
using System.Net.Http;

using System.Runtime.Serialization;

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

        gs_mpk MPK; //to change mpk


        

        #region timers
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                timer1.Stop();
                MPK.click_advset_menu();
                MPK.click_m_mpkextset1();
                //timer3.Start();
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
                MPK.click_next();
                nextCliked = true;
            }
            if (global_i < global_len)
            {
                MPK.click_addNewMPK();
                MPK.input_name(btn_list[global_i].name);
                MPK.input_userid(btn_list[global_i].userid);
                if (btn_list[global_i].mode=="blf")
                {
                    MPK.set_blf();
                }
                MPK.click_addok();
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
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Tab && tbMain.Focused)
            {
                tbMain.Text = tbMain.Text.Insert(tbMain.SelectionStart, "\t");
                //tbMain.SelectionStart = tbMain.SelectionStart + 1;
            }
            //return base.ProcessCmdKey(ref msg, keyData);
            return false;
        }
        private void btnNavigate_Click(object sender, EventArgs e)
        {
            if ( (cbUrl.Text.IndexOf("http://") != 0) /*|| (cbUrl.Text.IndexOf("https://") != 0)*/ )
            {
                cbUrl.Text = "http://" + cbUrl.Text;
            }
            string link = cbUrl.Text.Split('|')[0];
            webBrowser.Navigate(link);
        }
        private void btnUrlAdd_Click(object sender, EventArgs e)
        {
            cbUrl.Text += $"| {MPK.get_accountname()}";
            if (!cbUrl.Items.Contains(cbUrl.Text))
            {
                cbUrl.Items.Add(cbUrl.Text);
            }
        }
        private void btnUrlClear_Click(object sender, EventArgs e)
        {
            //cbUrl.Items.Clear();
            cbUrl.Items.Remove(cbUrl.SelectedItem);
        }
        private void cbUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnNavigate.PerformClick();
            }
        }
        private void btnDoLogin_Click(object sender, EventArgs e)
        {
            try
            {
                MPK.do_login(tbLogin.Text, tbPass.Text);
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
                MPK.click_prev();
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
                MPK.clear_mpk();
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
                    MPK.click_prev();
                }
                catch { }
                tbMain.Clear();
                tbMain.AppendText(MPK.get_blf_from_page());
                MPK.click_next();
                tbMain.AppendText(MPK.get_blf_from_page());
                MPK.click_prev();
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
            this.Text = $"{this.Text} [{UpdateChecker.GetCurVersion()}]";
            Thread threadChekUpdate = new Thread(UpdateChecker.ChekUpdate);
            threadChekUpdate.Start();
            Thread threadWikiInBrowser = new Thread(() => WikiLoader.wikiInBrowser(webBrowser, tbBrowserSorce.Text));
            threadWikiInBrowser.Start();

            PropertiesSaver.GetUrls(cbUrl);

            MPK = new gs_mpk(webBrowser);

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
            PropertiesSaver.SaveUrls(cbUrl);
        }
        
        #region For tests
        private void gbTest_MouseHover(object sender, EventArgs e)
        {
            gbTest.Height = 400;
        }
        private void btnGbTestHide_Click(object sender, EventArgs e)
        {
            gbTest.Height = 10;
        }
        private void btnTestBrowser_Click(object sender, EventArgs e)
        {
            webBrowser.DocumentText = Clipboard.GetText();
        }

        private void btnTest1_Click(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
