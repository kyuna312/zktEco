using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdooZK9500
{
    public partial class Master : Form
    {
        /// FingerPrintControl fingerPrintControl = null;
        UserControl userControl = null;
        public Master()
        {
            InitializeComponent();
            pnlStage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LoadUserControl();
            ///LoadFingerprintControl();

        }



        /// <summary>
        /// Before closing the application clear all the resources used by the application
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            try
            {

                ///if (fingerPrintControl != null)
                ///{
                ///    if (fingerPrintControl.cmbIdx.Items.Count > 0)
                ///        fingerPrintControl.OnDisconnect();
                ///}
            }
            catch
            { }
        }

        ///private void LoadFingerprintControl()
        ///{
        ///    fingerPrintControl = new FingerPrintControl();
        ///    fingerPrintControl.parentForm = this;
        ///    fingerPrintControl.Dock = DockStyle.Fill;
        ///    pnlStage.Controls.Add(fingerPrintControl);
        ///}
        
        private void LoadUserControl()
        {
            userControl = new UserControl();
            userControl.Dock = DockStyle.Fill;
            pnlStage.Controls.Add(userControl);
        }


        ///private void panel2_Paint(object sender, PaintEventArgs e)
        ///{
        ///    int y = panel2.Height;
        ///    GraphicsManager.DrawLine(panel2, Color.LightGray, 0, y, panel2.Width, y, 2);
        ///}

        private void statusBar_Load(object sender, System.EventArgs e)
        {

        }
    }
}
