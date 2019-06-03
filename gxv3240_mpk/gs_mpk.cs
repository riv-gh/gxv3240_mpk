using System;
using System.Windows.Forms;

namespace gxv3240_mpk
{
    class gs_mpk
    {
        WebBrowser webBrowser;
        public gs_mpk(WebBrowser wb)
        {
            webBrowser = wb;
        }

        public void click_addNewMPK()
        {
            webBrowser.Document.Window.Frames[0].Document.GetElementById("a_append").InvokeMember("click");
        }
        public void click_next()
        {
            webBrowser.Document.Window.Frames[0].Document.GetElementById("downpage").InvokeMember("click");
        }
        public void click_prev()
        {
            webBrowser.Document.Window.Frames[0].Document.GetElementById("uppage").InvokeMember("click");
        }
        public void input_name(string name)
        {
            webBrowser.Document.GetElementById("addname").SetAttribute("value", name);
        }
        public void input_userid(string userid)
        {
            webBrowser.Document.GetElementById("adduserid").SetAttribute("value", userid);
        }
        public void click_addok()
        {
            webBrowser.Document.GetElementById("a_addok").InvokeMember("click");
        }

        public void set_blf()
        {
            webBrowser.Document.GetElementById("addkeymode").SetAttribute("value", "1");
        }

        public void clear_mpk()
        {
            webBrowser.Document.Window.Frames[0].Document.GetElementById("t_check").InvokeMember("click");
            webBrowser.Document.Window.Frames[0].Document.GetElementById("all_del").InvokeMember("click");
            webBrowser.Document.Window.Frames[0].Document.GetElementById("jqi_state0_buttonOK").InvokeMember("click");
        }

        public void do_login(string login = "admin", string pass = "admin")
        {
            webBrowser.Document.GetElementById("username").SetAttribute("value", login);
            webBrowser.Document.GetElementById("password").SetAttribute("value", pass);
            webBrowser.Document.GetElementById("loginbtn").InvokeMember("click");
        }

        public void click_advset_menu()
        {
            webBrowser.Document.GetElementById("advset_menu").InvokeMember("click");
        }

        public void click_m_mpkextset1()
        {
            webBrowser.Document.GetElementById("m_mpkextset1").InvokeMember("click");
        }

        public string get_blf_from_page()
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
    }
}
