using System;

namespace gxv3240_mpk
{
    class gs_btn
    {
        public string name;
        public string userid;
        public string mode;

        public gs_btn() { }

        public gs_btn(string gs_btn_str, string def = "default")
        {
            string[] tmp_arr = gs_btn_str.Split('\t');
            name = tmp_arr[0];
            userid = tmp_arr[1];
            mode = (tmp_arr.Length < 3) ? def : tmp_arr[2];
        }

        public override string ToString()
        {
            return String.Format("name: {0}, userid: {1}, mode: {2}", name, userid, mode);
        }
    }
}
