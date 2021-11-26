namespace Cabinet_Medical
{
    partial class AddVechimeMediciForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodReteta = new System.Windows.Forms.TextBox();
            this.txtCodMedic = new System.Windows.Forms.TextBox();
            this.txtVechime = new System.Windows.Forms.TextBox();
            this.txtNrConsultatii = new System.Windows.Forms.TextBox();
            this.ckbActiv = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.epCodReteta = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCodMedic = new System.Windows.Forms.ErrorProvider(this.components);
            this.epVechime = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNrConsultatii = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.epCodReteta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCodMedic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epVechime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNrConsultatii)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(67, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod Reteta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(72, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cod Medic";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(72, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vechime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(15, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numar consultatii";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(95, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Activ";
            // 
            // txtCodReteta
            // 
            this.txtCodReteta.BackColor = System.Drawing.Color.Snow;
            this.txtCodReteta.Location = new System.Drawing.Point(287, 90);
            this.txtCodReteta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodReteta.Name = "txtCodReteta";
            this.txtCodReteta.Size = new System.Drawing.Size(89, 22);
            this.txtCodReteta.TabIndex = 5;
            this.txtCodReteta.TextChanged += new System.EventHandler(this.txtCodReteta_TextChanged);
            // 
            // txtCodMedic
            // 
            this.txtCodMedic.BackColor = System.Drawing.Color.Snow;
            this.txtCodMedic.Location = new System.Drawing.Point(287, 123);
            this.txtCodMedic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodMedic.Name = "txtCodMedic";
            this.txtCodMedic.Size = new System.Drawing.Size(89, 22);
            this.txtCodMedic.TabIndex = 6;
            this.txtCodMedic.TextChanged += new System.EventHandler(this.txtCodMedic_TextChanged);
            // 
            // txtVechime
            // 
            this.txtVechime.BackColor = System.Drawing.Color.Snow;
            this.txtVechime.Location = new System.Drawing.Point(287, 164);
            this.txtVechime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVechime.Name = "txtVechime";
            this.txtVechime.Size = new System.Drawing.Size(89, 22);
            this.txtVechime.TabIndex = 7;
            this.txtVechime.TextChanged += new System.EventHandler(this.txtVechime_TextChanged);
            // 
            // txtNrConsultatii
            // 
            this.txtNrConsultatii.BackColor = System.Drawing.Color.Snow;
            this.txtNrConsultatii.Location = new System.Drawing.Point(287, 210);
            this.txtNrConsultatii.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNrConsultatii.Name = "txtNrConsultatii";
            this.txtNrConsultatii.Size = new System.Drawing.Size(89, 22);
            this.txtNrConsultatii.TabIndex = 8;
            // 
            // ckbActiv
            // 
            this.ckbActiv.AutoSize = true;
            this.ckbActiv.BackColor = System.Drawing.Color.Snow;
            this.ckbActiv.Location = new System.Drawing.Point(313, 260);
            this.ckbActiv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbActiv.Name = "ckbActiv";
            this.ckbActiv.Size = new System.Drawing.Size(18, 17);
            this.ckbActiv.TabIndex = 9;
            this.ckbActiv.UseVisualStyleBackColor = false;
            this.ckbActiv.CheckedChanged += new System.EventHandler(this.ckbActiv_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkRed;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.btnSave.FlatAppearance.BorderSize = 3;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(207)))), ((int)(((byte)(211)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(440, 90);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 37);
            this.btnSave.TabIndex = 10;
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
            this.btnCancel.Location = new System.Drawing.Point(440, 197);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 38);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Renunta";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // epCodReteta
            // 
            this.epCodReteta.ContainerControl = this;
            // 
            // epCodMedic
            // 
            this.epCodMedic.ContainerControl = this;
            // 
            // epVechime
            // 
            this.epVechime.ContainerControl = this;
            // 
            // epNrConsultatii
            // 
            this.epNrConsultatii.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 52);
            this.panel1.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkRed;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(136, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Introduceti datele :";
            // 
            // AddVechimeMediciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(575, 308);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ckbActiv);
            this.Controls.Add(this.txtNrConsultatii);
            this.Controls.Add(this.txtVechime);
            this.Controls.Add(this.txtCodMedic);
            this.Controls.Add(this.txtCodReteta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddVechimeMediciForm";
            this.Text = "AddVechimeForm";
            this.Load += new System.EventHandler(this.AddVechimeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epCodReteta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCodMedic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epVechime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNrConsultatii)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodReteta;
        private System.Windows.Forms.TextBox txtCodMedic;
        private System.Windows.Forms.TextBox txtVechime;
        private System.Windows.Forms.TextBox txtNrConsultatii;
        private System.Windows.Forms.CheckBox ckbActiv;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider epCodReteta;
        private System.Windows.Forms.ErrorProvider epCodMedic;
        private System.Windows.Forms.ErrorProvider epVechime;
        private System.Windows.Forms.ErrorProvider epNrConsultatii;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
    }
}