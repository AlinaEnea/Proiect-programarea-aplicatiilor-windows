namespace Cabinet_Medical
{
    partial class AddPacientiForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbStatut = new System.Windows.Forms.ComboBox();
            this.cbMediu = new System.Windows.Forms.ComboBox();
            this.txtCodPacient = new System.Windows.Forms.TextBox();
            this.cbNrCabinet = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.epCodPacient = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNrCabinet = new System.Windows.Forms.ErrorProvider(this.components);
            this.epStatut = new System.Windows.Forms.ErrorProvider(this.components);
            this.epMediu = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.epCodPacient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNrCabinet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epStatut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMediu)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(57, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "CodPacient";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(57, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nr Cabinet";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(57, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Statut";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(57, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mediul";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbStatut
            // 
            this.cbStatut.BackColor = System.Drawing.Color.Snow;
            this.cbStatut.FormattingEnabled = true;
            this.cbStatut.Items.AddRange(new object[] {
            "Abonat",
            "Neabonat"});
            this.cbStatut.Location = new System.Drawing.Point(223, 191);
            this.cbStatut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStatut.Name = "cbStatut";
            this.cbStatut.Size = new System.Drawing.Size(179, 24);
            this.cbStatut.TabIndex = 4;
            this.cbStatut.SelectedIndexChanged += new System.EventHandler(this.cbStatut_SelectedIndexChanged);
            // 
            // cbMediu
            // 
            this.cbMediu.BackColor = System.Drawing.Color.Snow;
            this.cbMediu.FormattingEnabled = true;
            this.cbMediu.Items.AddRange(new object[] {
            "rural",
            "urban"});
            this.cbMediu.Location = new System.Drawing.Point(223, 241);
            this.cbMediu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMediu.Name = "cbMediu";
            this.cbMediu.Size = new System.Drawing.Size(179, 24);
            this.cbMediu.TabIndex = 5;
            this.cbMediu.SelectedIndexChanged += new System.EventHandler(this.cbMediu_SelectedIndexChanged);
            // 
            // txtCodPacient
            // 
            this.txtCodPacient.BackColor = System.Drawing.Color.Snow;
            this.txtCodPacient.Location = new System.Drawing.Point(228, 97);
            this.txtCodPacient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodPacient.Name = "txtCodPacient";
            this.txtCodPacient.Size = new System.Drawing.Size(179, 22);
            this.txtCodPacient.TabIndex = 6;
            this.txtCodPacient.TextChanged += new System.EventHandler(this.txtCodPacient_TextChanged);
            // 
            // cbNrCabinet
            // 
            this.cbNrCabinet.BackColor = System.Drawing.Color.Snow;
            this.cbNrCabinet.FormattingEnabled = true;
            this.cbNrCabinet.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbNrCabinet.Location = new System.Drawing.Point(223, 143);
            this.cbNrCabinet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNrCabinet.Name = "cbNrCabinet";
            this.cbNrCabinet.Size = new System.Drawing.Size(179, 24);
            this.cbNrCabinet.TabIndex = 7;
            this.cbNrCabinet.SelectedIndexChanged += new System.EventHandler(this.cbNrCabinet_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkRed;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.btnSave.FlatAppearance.BorderSize = 3;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(207)))), ((int)(((byte)(211)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(479, 137);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 39);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Salveaza";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.btnCancel.FlatAppearance.BorderSize = 3;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(207)))), ((int)(((byte)(211)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(479, 224);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 39);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Renunta";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // epCodPacient
            // 
            this.epCodPacient.ContainerControl = this;
            // 
            // epNrCabinet
            // 
            this.epNrCabinet.ContainerControl = this;
            // 
            // epStatut
            // 
            this.epStatut.ContainerControl = this;
            // 
            // epMediu
            // 
            this.epMediu.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 60);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkRed;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(89, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(467, 25);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Introduceti datele pacientului:";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddPacientiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(673, 319);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbNrCabinet);
            this.Controls.Add(this.txtCodPacient);
            this.Controls.Add(this.cbMediu);
            this.Controls.Add(this.cbStatut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddPacientiForm";
            this.Text = "AddAnStudiuForm";
            this.Load += new System.EventHandler(this.AddPacientiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epCodPacient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNrCabinet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epStatut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMediu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbStatut;
        private System.Windows.Forms.ComboBox cbMediu;
        private System.Windows.Forms.TextBox txtCodPacient;
        private System.Windows.Forms.ComboBox cbNrCabinet;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider epCodPacient;
        private System.Windows.Forms.ErrorProvider epNrCabinet;
        private System.Windows.Forms.ErrorProvider epStatut;
        private System.Windows.Forms.ErrorProvider epMediu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
    }
}