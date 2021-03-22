using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Facebook_Page_Api
{
    public partial class fb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var request = WebRequest.Create("https://graph.facebook.com/utc2hcmc/posts?access_token=EAAAAZAw4FxQIBAGgMO8luzwscA8ZCfQgeFNHQCgEuTOUIVPCEOtgHTWlE0h2ToW3CTO7NZBPc9xDBlEcTo20bshtf2cBtrXKZBfvHTAH4WZAkbdLMGtFZAiZBr3XlAGaLvr6Khq6Bce3uT2lwQnQyStTtl5uC0DkG8U5X7KZAn4LlQZDZD");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseString = reader.ReadToEnd();
            dynamic jsonData = JsonConvert.DeserializeObject(responseString);
            string s = "";
            for (int i = 0; i < 10; i++)
            {
                s += "<b>Bài đăng thứ " + (i + 1) + ": </b>" + "</br>";
                s += "<b>Ngày đăng: </b>" + jsonData.data[i].created_time + "</br>";
                s += "<b>Nội dung: </b>" + jsonData.data[i].message + "</br>";
                s += "<b>Link bài viết: </b>" + jsonData.data[i].actions[0].link + "</br>";
            }
            Label1.Text = s;
        }
    }
}

