namespace dental_desktop
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pMenuLeft = new System.Windows.Forms.Panel();
            this.pMenuTop = new System.Windows.Forms.Panel();
            this.pContent = new System.Windows.Forms.Panel();
            this.btnTema = new System.Windows.Forms.Button();
            this.btnConfMT = new System.Windows.Forms.Button();
            this.btnProfesionalesMT = new System.Windows.Forms.Button();
            this.btnClinicasMT = new System.Windows.Forms.Button();
            this.btnComunicacionMT = new System.Windows.Forms.Button();
            this.btnAgendaMT = new System.Windows.Forms.Button();
            this.btnPacientesMT = new System.Windows.Forms.Button();
            this.pbMaximizeDashboard = new System.Windows.Forms.PictureBox();
            this.btnDashboardMT = new System.Windows.Forms.Button();
            this.pbMinimizeDashboard = new System.Windows.Forms.PictureBox();
            this.pbCloseDashboard = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pMenuLeft.SuspendLayout();
            this.pMenuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizeDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizeDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pMenuLeft
            // 
            this.pMenuLeft.BackColor = System.Drawing.Color.White;
            this.pMenuLeft.Controls.Add(this.btnLogout);
            this.pMenuLeft.Controls.Add(this.btnDashboard);
            this.pMenuLeft.Controls.Add(this.button1);
            this.pMenuLeft.Controls.Add(this.pictureBox1);
            this.pMenuLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenuLeft.Location = new System.Drawing.Point(0, 0);
            this.pMenuLeft.Name = "pMenuLeft";
            this.pMenuLeft.Size = new System.Drawing.Size(220, 650);
            this.pMenuLeft.TabIndex = 0;
            // 
            // pMenuTop
            // 
            this.pMenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(135)))), ((int)(((byte)(208)))));
            this.pMenuTop.Controls.Add(this.btnTema);
            this.pMenuTop.Controls.Add(this.btnConfMT);
            this.pMenuTop.Controls.Add(this.btnProfesionalesMT);
            this.pMenuTop.Controls.Add(this.btnClinicasMT);
            this.pMenuTop.Controls.Add(this.btnComunicacionMT);
            this.pMenuTop.Controls.Add(this.btnAgendaMT);
            this.pMenuTop.Controls.Add(this.btnPacientesMT);
            this.pMenuTop.Controls.Add(this.pbMaximizeDashboard);
            this.pMenuTop.Controls.Add(this.btnDashboardMT);
            this.pMenuTop.Controls.Add(this.pbMinimizeDashboard);
            this.pMenuTop.Controls.Add(this.pbCloseDashboard);
            this.pMenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMenuTop.Location = new System.Drawing.Point(220, 0);
            this.pMenuTop.Name = "pMenuTop";
            this.pMenuTop.Size = new System.Drawing.Size(1080, 64);
            this.pMenuTop.TabIndex = 1;
            this.pMenuTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pMenuTop_MouseDown);
            // 
            // pContent
            // 
            this.pContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.pContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContent.Location = new System.Drawing.Point(220, 64);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(1080, 586);
            this.pContent.TabIndex = 2;
            // 
            // btnTema
            // 
            this.btnTema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTema.FlatAppearance.BorderSize = 0;
            this.btnTema.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTema.Font = new System.Drawing.Font("DM Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTema.ForeColor = System.Drawing.Color.White;
            this.btnTema.Image = ((System.Drawing.Image)(resources.GetObject("btnTema.Image")));
            this.btnTema.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTema.Location = new System.Drawing.Point(871, 1);
            this.btnTema.Name = "btnTema";
            this.btnTema.Size = new System.Drawing.Size(112, 64);
            this.btnTema.TabIndex = 10;
            this.btnTema.Text = "Temas Prueba";
            this.btnTema.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTema.UseVisualStyleBackColor = true;
            this.btnTema.Click += new System.EventHandler(this.btnTema_Click);
            // 
            // btnConfMT
            // 
            this.btnConfMT.BackColor = System.Drawing.Color.Transparent;
            this.btnConfMT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfMT.FlatAppearance.BorderSize = 0;
            this.btnConfMT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnConfMT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfMT.Font = new System.Drawing.Font("DM Sans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfMT.ForeColor = System.Drawing.Color.Transparent;
            this.btnConfMT.Image = global::dental_desktop.Properties.Resources.SettingBackWhite_32x32;
            this.btnConfMT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfMT.Location = new System.Drawing.Point(582, 0);
            this.btnConfMT.Name = "btnConfMT";
            this.btnConfMT.Size = new System.Drawing.Size(91, 64);
            this.btnConfMT.TabIndex = 6;
            this.btnConfMT.Text = "Configuración";
            this.btnConfMT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfMT.UseVisualStyleBackColor = false;
            // 
            // btnProfesionalesMT
            // 
            this.btnProfesionalesMT.BackColor = System.Drawing.Color.Transparent;
            this.btnProfesionalesMT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProfesionalesMT.FlatAppearance.BorderSize = 0;
            this.btnProfesionalesMT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnProfesionalesMT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfesionalesMT.Font = new System.Drawing.Font("DM Sans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfesionalesMT.ForeColor = System.Drawing.Color.Transparent;
            this.btnProfesionalesMT.Image = global::dental_desktop.Properties.Resources.WeightBackWhite_32x32;
            this.btnProfesionalesMT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProfesionalesMT.Location = new System.Drawing.Point(485, 0);
            this.btnProfesionalesMT.Name = "btnProfesionalesMT";
            this.btnProfesionalesMT.Size = new System.Drawing.Size(91, 64);
            this.btnProfesionalesMT.TabIndex = 8;
            this.btnProfesionalesMT.Text = "Profesionales";
            this.btnProfesionalesMT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProfesionalesMT.UseVisualStyleBackColor = false;
            // 
            // btnClinicasMT
            // 
            this.btnClinicasMT.BackColor = System.Drawing.Color.Transparent;
            this.btnClinicasMT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClinicasMT.FlatAppearance.BorderSize = 0;
            this.btnClinicasMT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnClinicasMT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClinicasMT.Font = new System.Drawing.Font("DM Sans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClinicasMT.ForeColor = System.Drawing.Color.Transparent;
            this.btnClinicasMT.Image = global::dental_desktop.Properties.Resources.HeartBackWhite_32x32;
            this.btnClinicasMT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClinicasMT.Location = new System.Drawing.Point(388, 0);
            this.btnClinicasMT.Name = "btnClinicasMT";
            this.btnClinicasMT.Size = new System.Drawing.Size(91, 64);
            this.btnClinicasMT.TabIndex = 7;
            this.btnClinicasMT.Text = "Clinicas";
            this.btnClinicasMT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClinicasMT.UseVisualStyleBackColor = false;
            // 
            // btnComunicacionMT
            // 
            this.btnComunicacionMT.BackColor = System.Drawing.Color.Transparent;
            this.btnComunicacionMT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnComunicacionMT.FlatAppearance.BorderSize = 0;
            this.btnComunicacionMT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnComunicacionMT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComunicacionMT.Font = new System.Drawing.Font("DM Sans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComunicacionMT.ForeColor = System.Drawing.Color.Transparent;
            this.btnComunicacionMT.Image = ((System.Drawing.Image)(resources.GetObject("btnComunicacionMT.Image")));
            this.btnComunicacionMT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnComunicacionMT.Location = new System.Drawing.Point(291, 0);
            this.btnComunicacionMT.Name = "btnComunicacionMT";
            this.btnComunicacionMT.Size = new System.Drawing.Size(91, 64);
            this.btnComunicacionMT.TabIndex = 8;
            this.btnComunicacionMT.Text = "Comunicación";
            this.btnComunicacionMT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnComunicacionMT.UseVisualStyleBackColor = false;
            // 
            // btnAgendaMT
            // 
            this.btnAgendaMT.BackColor = System.Drawing.Color.Transparent;
            this.btnAgendaMT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgendaMT.FlatAppearance.BorderSize = 0;
            this.btnAgendaMT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAgendaMT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendaMT.Font = new System.Drawing.Font("DM Sans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendaMT.ForeColor = System.Drawing.Color.Transparent;
            this.btnAgendaMT.Image = global::dental_desktop.Properties.Resources.OpenBackWhite_32x32;
            this.btnAgendaMT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgendaMT.Location = new System.Drawing.Point(194, 0);
            this.btnAgendaMT.Name = "btnAgendaMT";
            this.btnAgendaMT.Size = new System.Drawing.Size(91, 64);
            this.btnAgendaMT.TabIndex = 9;
            this.btnAgendaMT.Text = "Agenda";
            this.btnAgendaMT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgendaMT.UseVisualStyleBackColor = false;
            // 
            // btnPacientesMT
            // 
            this.btnPacientesMT.BackColor = System.Drawing.Color.Transparent;
            this.btnPacientesMT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPacientesMT.FlatAppearance.BorderSize = 0;
            this.btnPacientesMT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnPacientesMT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientesMT.Font = new System.Drawing.Font("DM Sans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientesMT.ForeColor = System.Drawing.Color.Transparent;
            this.btnPacientesMT.Image = global::dental_desktop.Properties.Resources.PersonesBackWhite_32x32;
            this.btnPacientesMT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPacientesMT.Location = new System.Drawing.Point(97, 0);
            this.btnPacientesMT.Name = "btnPacientesMT";
            this.btnPacientesMT.Size = new System.Drawing.Size(91, 64);
            this.btnPacientesMT.TabIndex = 5;
            this.btnPacientesMT.Text = "Pacientes";
            this.btnPacientesMT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPacientesMT.UseVisualStyleBackColor = false;
            // 
            // pbMaximizeDashboard
            // 
            this.pbMaximizeDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMaximizeDashboard.Image = ((System.Drawing.Image)(resources.GetObject("pbMaximizeDashboard.Image")));
            this.pbMaximizeDashboard.Location = new System.Drawing.Point(1029, 0);
            this.pbMaximizeDashboard.Name = "pbMaximizeDashboard";
            this.pbMaximizeDashboard.Size = new System.Drawing.Size(20, 20);
            this.pbMaximizeDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMaximizeDashboard.TabIndex = 2;
            this.pbMaximizeDashboard.TabStop = false;
            this.pbMaximizeDashboard.Click += new System.EventHandler(this.pbMaximizeDashboard_Click);
            // 
            // btnDashboardMT
            // 
            this.btnDashboardMT.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboardMT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDashboardMT.FlatAppearance.BorderSize = 0;
            this.btnDashboardMT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnDashboardMT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboardMT.Font = new System.Drawing.Font("DM Sans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboardMT.ForeColor = System.Drawing.Color.Transparent;
            this.btnDashboardMT.Image = global::dental_desktop.Properties.Resources.HomeBackWhite_32x32;
            this.btnDashboardMT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDashboardMT.Location = new System.Drawing.Point(0, 0);
            this.btnDashboardMT.Name = "btnDashboardMT";
            this.btnDashboardMT.Size = new System.Drawing.Size(91, 64);
            this.btnDashboardMT.TabIndex = 6;
            this.btnDashboardMT.Text = "Dashboard";
            this.btnDashboardMT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDashboardMT.UseVisualStyleBackColor = false;
            // 
            // pbMinimizeDashboard
            // 
            this.pbMinimizeDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimizeDashboard.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimizeDashboard.Image")));
            this.pbMinimizeDashboard.Location = new System.Drawing.Point(998, 0);
            this.pbMinimizeDashboard.Name = "pbMinimizeDashboard";
            this.pbMinimizeDashboard.Size = new System.Drawing.Size(20, 20);
            this.pbMinimizeDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimizeDashboard.TabIndex = 1;
            this.pbMinimizeDashboard.TabStop = false;
            this.pbMinimizeDashboard.Click += new System.EventHandler(this.pbMinimizeDashboard_Click);
            // 
            // pbCloseDashboard
            // 
            this.pbCloseDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCloseDashboard.Image = ((System.Drawing.Image)(resources.GetObject("pbCloseDashboard.Image")));
            this.pbCloseDashboard.Location = new System.Drawing.Point(1060, 0);
            this.pbCloseDashboard.Name = "pbCloseDashboard";
            this.pbCloseDashboard.Size = new System.Drawing.Size(20, 20);
            this.pbCloseDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCloseDashboard.TabIndex = 0;
            this.pbCloseDashboard.TabStop = false;
            this.pbCloseDashboard.Click += new System.EventHandler(this.pbCloseDashboard_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("DM Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogout.Location = new System.Drawing.Point(0, 591);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(220, 59);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Gray;
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("DM Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::dental_desktop.Properties.Resources.List_25x25;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(12, 150);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(191, 32);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "DashBoard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("DM Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::dental_desktop.Properties.Resources.Text_25x25;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ingresos";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(149)))), ((int)(((byte)(125)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.pContent);
            this.Controls.Add(this.pMenuTop);
            this.Controls.Add(this.pMenuLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.pMenuLeft.ResumeLayout(false);
            this.pMenuTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizeDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizeDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMenuLeft;
        private System.Windows.Forms.Panel pMenuTop;
        private System.Windows.Forms.PictureBox pbCloseDashboard;
        private System.Windows.Forms.Panel pContent;
        private System.Windows.Forms.PictureBox pbMaximizeDashboard;
        private System.Windows.Forms.PictureBox pbMinimizeDashboard;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPacientesMT;
        private System.Windows.Forms.Button btnDashboardMT;
        private System.Windows.Forms.Button btnConfMT;
        private System.Windows.Forms.Button btnAgendaMT;
        private System.Windows.Forms.Button btnComunicacionMT;
        private System.Windows.Forms.Button btnClinicasMT;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnTema;
        private System.Windows.Forms.Button btnProfesionalesMT;
    }
}