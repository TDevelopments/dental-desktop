using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace dental_desktop
{
    public partial class Dashboard : Form
    {
        Boolean max = true;
        Boolean theme = true;
        
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
        public Dashboard()
        {
            InitializeComponent();

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void pbCloseDashboard_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMaximizeDashboard_Click(object sender, EventArgs e)
        {
            if (max)
            {
                //this.WindowState = FormWindowState.Maximized;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                max = false;
                //MessageBox.Show(max.ToString() + "; Location: " + Location.ToString() + "; Size: " + Size.ToString(), "Mensaje 2");
            }
            else
            {
                //this.WindowState = FormWindowState.Normal;
                System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
                this.Size = new System.Drawing.Size(workingRectangle.Width - 66, workingRectangle.Height - 78);
                this.Location = new System.Drawing.Point((Screen.PrimaryScreen.Bounds.Width - this.Width)/2, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

                max = true;
                //MessageBox.Show(max.ToString() + "; Location: " + Location.ToString() + "; Size: " + Size.ToString(), "Mensaje 3");
            }
        }

        private void pbMinimizeDashboard_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void pMenuTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnTema_Click(object sender, EventArgs e)
        {
            if(theme)
            {
                //Panel Colors Night
                pMenuLeft.BackColor = Color.FromArgb(26, 32, 40);
                pContent.BackColor = Color.FromArgb(46, 66, 82);
                theme = false;
            }
            else
            {
                //Panel Colors Day
                pMenuLeft.BackColor = Color.FromArgb(255, 255, 255);
                pContent.BackColor = Color.FromArgb(245, 246, 248);
                //Button Colors and text
                //btnDashboard.Image = dental_desktop.Properties.Resources;
                theme = true;
            }
        }
    }
    public class GradientPanel : Panel
    {
        public Color TopColor { get; set; }

        public Color BottomColor { get; set; }

        public float Angle { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.TopColor, this.BottomColor, this.Angle);
            Graphics g = e.Graphics;
            g.FillRectangle(brush, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
