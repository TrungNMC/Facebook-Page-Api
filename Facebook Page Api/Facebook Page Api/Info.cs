using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Facebook_Page_Api
{
    public class Info
    {
        private String thoigian;
        private String noidung;
        private String url;

        public string Thoigian { get => thoigian; set => thoigian = value; }
        public string Noidung { get => noidung; set => noidung = value; }
        public string Url { get => url; set => url = value; }
    }
}