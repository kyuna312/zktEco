using libzkfpcsharp;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using ZKTecoFingerPrintScanner_Implementation;
using ZKTecoFingerPrintScanner_Implementation.Helpers;

namespace Dofe_Re_Entry.UserControls.DeviceController
{
    public partial class LoginControl : UserControl
    {

        #region -------- FIELDS --------

        const int REGISTER_FINGER_COUNT = 3;

        zkfp fpInstance = new zkfp();
        IntPtr FormHandle = IntPtr.Zero; // To hold the handle of the form
        bool bIsTimeToDie = false;
        bool IsRegister = false;
        bool bIdentify = true;
        byte[] FPBuffer;   // Image Buffer
        int RegisterCount = 0;

        byte[][] RegTmps = new byte[REGISTER_FINGER_COUNT][];

        byte[] RegTmp = new byte[2048];
        byte[] CapTmp = new byte[2048];
        int cbCapTmp = 2048;
        int regTempLen = 0;
        int iFid = 1;

        const int MESSAGE_CAPTURED_OK = 0x0400 + 6;


        

        private int mfpWidth = 0;
        private int mfpHeight = 0;


        #endregion
        Thread captureThread = null;
        public Master parentForm = null;
        FingerPrintControl fingerPrintControl = null;

        // [ CONSTRUCTOR ]
        public LoginControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ipText = new System.Windows.Forms.TextBox();
            this.userText = new System.Windows.Forms.TextBox();
            this.passText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(45, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Нэвтрэх";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ip";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // ipText
            // 
            this.ipText.Location = new System.Drawing.Point(128, 78);
            this.ipText.Multiline = true;
            this.ipText.Name = "ipText";
            this.ipText.Size = new System.Drawing.Size(185, 31);
            this.ipText.TabIndex = 4;
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(128, 123);
            this.userText.Multiline = true;
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(185, 31);
            this.userText.TabIndex = 5;
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(128, 168);
            this.passText.Multiline = true;
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(185, 31);
            this.passText.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(25, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Нэвтрэх";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginControl
            // 
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.ipText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(355, 270);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ip, username, password;
            ip = ipText.Text;
            username = userText.Text;
            password = passText.Text;
            try
            {
                Uri uri = new Uri($"http://{ip}/api/auth/get_tokens?username={username}&password={password}");
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
                request.Method = "POST";
                NetworkCredential credentials = new NetworkCredential("user", "password");
                request.Credentials = credentials;

                WebResponse v = request.GetResponse();
                Stream rStream = v.GetResponseStream();
                StreamReader str = new StreamReader(rStream);
                if (str.EndOfStream != true)
                {
                    passText.Text = str.ReadToEnd();

                }

                v.Close();
                rStream.Close();
                str.Close();
                passText.Text = "success";

                FingerPrintControl fingerPrintControl = new FingerPrintControl();
                fingerPrintControl.Show();
                this.Hide();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}
