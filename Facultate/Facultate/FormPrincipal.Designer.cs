namespace Cabinet_Medical
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mediciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incarcaDateDinFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaDateInFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reteteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bazededateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veziDateCompleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medieConsultatiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asistentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schimbaCuloareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fundalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMedie = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkRed;
            this.menuStrip1.Font = new System.Drawing.Font("Ink Free", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mediciToolStripMenuItem,
            this.reteteToolStripMenuItem,
            this.pacientiToolStripMenuItem,
            this.bazededateToolStripMenuItem,
            this.graficeToolStripMenuItem,
            this.asistentiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(967, 39);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mediciToolStripMenuItem
            // 
            this.mediciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incarcaDateDinFisierToolStripMenuItem,
            this.salveazaDateInFisierToolStripMenuItem});
            this.mediciToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.mediciToolStripMenuItem.Name = "mediciToolStripMenuItem";
            this.mediciToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 3, 4, 0);
            this.mediciToolStripMenuItem.Size = new System.Drawing.Size(85, 37);
            this.mediciToolStripMenuItem.Text = "Medici";
            this.mediciToolStripMenuItem.Click += new System.EventHandler(this.mediciToolStripMenuItem_Click);
            // 
            // incarcaDateDinFisierToolStripMenuItem
            // 
            this.incarcaDateDinFisierToolStripMenuItem.Name = "incarcaDateDinFisierToolStripMenuItem";
            this.incarcaDateDinFisierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.incarcaDateDinFisierToolStripMenuItem.Size = new System.Drawing.Size(409, 34);
            this.incarcaDateDinFisierToolStripMenuItem.Text = "Incarca date din fisier";
            this.incarcaDateDinFisierToolStripMenuItem.Click += new System.EventHandler(this.incarcaDateDinFisierToolStripMenuItem_Click);
            // 
            // salveazaDateInFisierToolStripMenuItem
            // 
            this.salveazaDateInFisierToolStripMenuItem.Name = "salveazaDateInFisierToolStripMenuItem";
            this.salveazaDateInFisierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salveazaDateInFisierToolStripMenuItem.Size = new System.Drawing.Size(409, 34);
            this.salveazaDateInFisierToolStripMenuItem.Text = "Salveaza date in fisier";
            this.salveazaDateInFisierToolStripMenuItem.Click += new System.EventHandler(this.salveazaDateInFisierToolStripMenuItem_Click);
            // 
            // reteteToolStripMenuItem
            // 
            this.reteteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareToolStripMenuItem,
            this.deserializareToolStripMenuItem});
            this.reteteToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.reteteToolStripMenuItem.Name = "reteteToolStripMenuItem";
            this.reteteToolStripMenuItem.Size = new System.Drawing.Size(99, 37);
            this.reteteToolStripMenuItem.Text = "Retete";
            this.reteteToolStripMenuItem.Click += new System.EventHandler(this.ReteteToolStripMenuItem_Click);
            // 
            // serializareToolStripMenuItem
            // 
            this.serializareToolStripMenuItem.Name = "serializareToolStripMenuItem";
            this.serializareToolStripMenuItem.Size = new System.Drawing.Size(234, 34);
            this.serializareToolStripMenuItem.Text = "Serializare";
            this.serializareToolStripMenuItem.Click += new System.EventHandler(this.serializareToolStripMenuItem_Click);
            // 
            // deserializareToolStripMenuItem
            // 
            this.deserializareToolStripMenuItem.Name = "deserializareToolStripMenuItem";
            this.deserializareToolStripMenuItem.Size = new System.Drawing.Size(234, 34);
            this.deserializareToolStripMenuItem.Text = "Deserializare";
            this.deserializareToolStripMenuItem.Click += new System.EventHandler(this.deserializareToolStripMenuItem_Click);
            // 
            // pacientiToolStripMenuItem
            // 
            this.pacientiToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.pacientiToolStripMenuItem.Name = "pacientiToolStripMenuItem";
            this.pacientiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.pacientiToolStripMenuItem.Size = new System.Drawing.Size(106, 37);
            this.pacientiToolStripMenuItem.Text = "Pacienti";
            this.pacientiToolStripMenuItem.Click += new System.EventHandler(this.vechimeToolStripMenuItem_Click);
            // 
            // bazededateToolStripMenuItem
            // 
            this.bazededateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veziDateCompleteToolStripMenuItem});
            this.bazededateToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.bazededateToolStripMenuItem.Name = "bazededateToolStripMenuItem";
            this.bazededateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.bazededateToolStripMenuItem.Size = new System.Drawing.Size(231, 37);
            this.bazededateToolStripMenuItem.Text = "Baze de date Medici";
            this.bazededateToolStripMenuItem.Click += new System.EventHandler(this.bazededateToolStripMenuItem_Click);
            // 
            // veziDateCompleteToolStripMenuItem
            // 
            this.veziDateCompleteToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.veziDateCompleteToolStripMenuItem.Name = "veziDateCompleteToolStripMenuItem";
            this.veziDateCompleteToolStripMenuItem.Size = new System.Drawing.Size(301, 34);
            this.veziDateCompleteToolStripMenuItem.Text = "Vezi Date Complete";
            this.veziDateCompleteToolStripMenuItem.Click += new System.EventHandler(this.veziDateCompleteToolStripMenuItem_Click);
            // 
            // graficeToolStripMenuItem
            // 
            this.graficeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medieConsultatiiToolStripMenuItem});
            this.graficeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.graficeToolStripMenuItem.Name = "graficeToolStripMenuItem";
            this.graficeToolStripMenuItem.Size = new System.Drawing.Size(102, 37);
            this.graficeToolStripMenuItem.Text = "&Grafice";
            this.graficeToolStripMenuItem.Click += new System.EventHandler(this.graficeToolStripMenuItem_Click);
            // 
            // medieConsultatiiToolStripMenuItem
            // 
            this.medieConsultatiiToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.medieConsultatiiToolStripMenuItem.Name = "medieConsultatiiToolStripMenuItem";
            this.medieConsultatiiToolStripMenuItem.Size = new System.Drawing.Size(274, 34);
            this.medieConsultatiiToolStripMenuItem.Text = "Medie-Conslutatii";
            this.medieConsultatiiToolStripMenuItem.Click += new System.EventHandler(this.medieMediciToolStripMenuItem_Click);
            // 
            // asistentiToolStripMenuItem
            // 
            this.asistentiToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.asistentiToolStripMenuItem.Name = "asistentiToolStripMenuItem";
            this.asistentiToolStripMenuItem.Size = new System.Drawing.Size(120, 37);
            this.asistentiToolStripMenuItem.Text = "Asistenti";
            this.asistentiToolStripMenuItem.Click += new System.EventHandler(this.asistentiToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificaToolStripMenuItem,
            this.stergeToolStripMenuItem,
            this.schimbaCuloareToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(189, 76);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.modificaToolStripMenuItem.Text = "Modifica";
            this.modificaToolStripMenuItem.Click += new System.EventHandler(this.modificaToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // schimbaCuloareToolStripMenuItem
            // 
            this.schimbaCuloareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fundalToolStripMenuItem,
            this.textToolStripMenuItem});
            this.schimbaCuloareToolStripMenuItem.Name = "schimbaCuloareToolStripMenuItem";
            this.schimbaCuloareToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.schimbaCuloareToolStripMenuItem.Text = "Schimba culoare";
            // 
            // fundalToolStripMenuItem
            // 
            this.fundalToolStripMenuItem.Name = "fundalToolStripMenuItem";
            this.fundalToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.fundalToolStripMenuItem.Text = "Fundal";
            this.fundalToolStripMenuItem.Click += new System.EventHandler(this.fundalToolStripMenuItem_Click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.textToolStripMenuItem.Text = "Text";
            this.textToolStripMenuItem.Click += new System.EventHandler(this.textToolStripMenuItem_Click);
            // 
            // lblMedie
            // 
            this.lblMedie.AutoSize = true;
            this.lblMedie.Location = new System.Drawing.Point(40, 498);
            this.lblMedie.Name = "lblMedie";
            this.lblMedie.Size = new System.Drawing.Size(0, 17);
            this.lblMedie.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(858, 435);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(967, 522);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMedie);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPrincipal";
            this.Text = "00000000";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mediciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reteteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bazededateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veziDateCompleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schimbaCuloareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fundalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incarcaDateDinFisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaDateInFisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareToolStripMenuItem;
        private System.Windows.Forms.Label lblMedie;
        private System.Windows.Forms.ToolStripMenuItem graficeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medieConsultatiiToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem asistentiToolStripMenuItem;
    }
}

