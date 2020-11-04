using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Web.Script.Serialization;
using System.Net;
using Newtonsoft.Json;

namespace dental_desktop
{
    public partial class frmLogin : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 161;

        private const int HTCAPTION = 2;
      
        public class User
        {
            public string email { get; set; }
            public string password { get; set; }
        }

        public frmLogin()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnIngresar_Paint(object sender, PaintEventArgs e)
        {
            btnIngresar.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0,117,44,10,10));
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Ingresa tu correo electrónico")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.Black;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Ingresa tu correo electrónico";

                txtCorreo.ForeColor = Color.Silver;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Ingresa tu contraseña")
            {
                txtContraseña.UseSystemPasswordChar = true;
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.UseSystemPasswordChar = false;
                txtContraseña.Text = "Ingresa tu contraseña";
                txtContraseña.ForeColor = Color.Silver;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string url = "http://localhost:3000/api/v1/doctors/login";
            string result = "";

            User user = new User()
            {
                email = txtCorreo.Text,
                password = txtContraseña.Text
            };

            WebRequest oRequest = WebRequest.Create(url);
            oRequest.Method = "post";
            oRequest.ContentType = "application/json;charset=UTF-8";

            using (var oSW = new StreamWriter(oRequest.GetRequestStream()))
            {
                //string json = "{\"email\": \""+ txtCorreo.Text + "\",\"password\": \"" + txtContraseña.Text + "\"}";
                string json = JsonConvert.SerializeObject(user, Formatting.Indented);
                oSW.Write(json);
                oSW.Flush();
                oSW.Close();
            }

            WebResponse oResponse = oRequest.GetResponse();

            using (var oSR = new StreamReader(oResponse.GetResponseStream()))
            {
                result = oSR.ReadToEnd();

                var jss = new JavaScriptSerializer();
                var dict = jss.Deserialize<Dictionary<string, string>>(result);
                MessageBox.Show(dict["token"]);
                Properties.Settings.Default.Token = dict["token"];
                Properties.Settings.Default.Save();
                MessageBox.Show(Properties.Settings.Default.Token.ToString());
            }
            //lblComplete.Text = result;
        }

        private void pnlCorreo_Click(object sender, EventArgs e)
        {
            txtCorreo.Focus();
        }

        private void pnlContraseña_Click(object sender, EventArgs e)
        {
            txtContraseña.Focus();
        }
    }
}
