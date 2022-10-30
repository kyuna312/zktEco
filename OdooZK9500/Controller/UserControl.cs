using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdooZK9500.Controller
{
    public partial class UserControl : System.Windows.Forms.UserControl
    {
        public UserControl()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            try
            {
                Uri uri = new Uri("http://" + ip_text.Text + "/api/auth/get_tokens?" + "username="+ user_text.Text + "&password=" + pass_text.Text);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
                request.Method = "POST";
                NetworkCredential credentials = new NetworkCredential("user", "password");
                request.Credentials = credentials;

                WebResponse v = request.GetResponse();
                Stream rStream = v.GetResponseStream();
                StreamReader str = new StreamReader(rStream);
                if (str.EndOfStream != true)
                {
                    pass_text.Text = str.ReadToEnd();

                }
                v.Close();
                rStream.Close();
                str.Close();
                pass_text.Text = "success";

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        } 
    }
}
