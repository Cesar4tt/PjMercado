namespace ProjetoMercado
{
    partial class frmSplashScreen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashScreen));
            panelCarregar = new Panel();
            gifLogo = new PictureBox();
            timerCarregar = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)gifLogo).BeginInit();
            SuspendLayout();
            // 
            // panelCarregar
            // 
            panelCarregar.BackColor = Color.FromArgb(2, 111, 216);
            panelCarregar.Location = new Point(0, 311);
            panelCarregar.Name = "panelCarregar";
            panelCarregar.Size = new Size(10, 15);
            panelCarregar.TabIndex = 0;
            // 
            // gifLogo
            // 
            gifLogo.Dock = DockStyle.Fill;
            gifLogo.Image = Properties.Resources.emporio;
            gifLogo.Location = new Point(0, 0);
            gifLogo.Name = "gifLogo";
            gifLogo.Size = new Size(500, 326);
            gifLogo.TabIndex = 1;
            gifLogo.TabStop = false;
            // 
            // timerCarregar
            // 
            timerCarregar.Enabled = true;
            timerCarregar.Interval = 15;
            timerCarregar.Tick += timerCarregar_Tick;
            // 
            // frmSplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 326);
            Controls.Add(panelCarregar);
            Controls.Add(gifLogo);
            Cursor = Cursors.AppStarting;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmSplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSplashScreen";
            ((System.ComponentModel.ISupportInitialize)gifLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCarregar;
        private PictureBox gifLogo;
        private System.Windows.Forms.Timer timerCarregar;
    }
}