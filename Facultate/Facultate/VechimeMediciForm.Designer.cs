namespace Cabinet_Medical
{
    partial class VechimeMediciForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.Color.Empty, System.Drawing.Color.PapayaWhip, null);
            this.listViewVechimeMedici = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inapoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewVechimeMedici
            // 
            this.listViewVechimeMedici.BackColor = System.Drawing.Color.Snow;
            this.listViewVechimeMedici.GridLines = true;
            this.listViewVechimeMedici.HideSelection = false;
            this.listViewVechimeMedici.HoverSelection = true;
            listViewItem1.StateImageIndex = 0;
            this.listViewVechimeMedici.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewVechimeMedici.LabelEdit = true;
            this.listViewVechimeMedici.Location = new System.Drawing.Point(39, 65);
            this.listViewVechimeMedici.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewVechimeMedici.Name = "listViewVechimeMedici";
            this.listViewVechimeMedici.Size = new System.Drawing.Size(808, 413);
            this.listViewVechimeMedici.TabIndex = 0;
            this.listViewVechimeMedici.UseCompatibleStateImageBehavior = false;
            this.listViewVechimeMedici.SelectedIndexChanged += new System.EventHandler(this.listViewNote_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkRed;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inapoiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(944, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // inapoiToolStripMenuItem
            // 
            this.inapoiToolStripMenuItem.BackColor = System.Drawing.Color.DarkRed;
            this.inapoiToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inapoiToolStripMenuItem.Name = "inapoiToolStripMenuItem";
            this.inapoiToolStripMenuItem.Size = new System.Drawing.Size(72, 22);
            this.inapoiToolStripMenuItem.Text = "Inapoi";
            this.inapoiToolStripMenuItem.Click += new System.EventHandler(this.inapoiToolStripMenuItem_Click);
            // 
            // VechimeMediciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(944, 543);
            this.Controls.Add(this.listViewVechimeMedici);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VechimeMediciForm";
            this.Text = "Vechime Medici";
            this.Load += new System.EventHandler(this.NoteStudentiForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewVechimeMedici;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inapoiToolStripMenuItem;
    }
}