namespace Cabinet_Medical
{
    partial class AddMedicForm
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
            this.lblNume = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblDataN = new System.Windows.Forms.Label();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.epMedicNume = new System.Windows.Forms.ErrorProvider(this.components);
            this.epMedicPrenume = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCodCabinet = new System.Windows.Forms.Label();
            this.txtCodCabinet = new System.Windows.Forms.TextBox();
            this.epMedicCodCabinet = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epMedicNume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMedicPrenume)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMedicCodCabinet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.BackColor = System.Drawing.Color.Snow;
            this.lblNume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNume.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.ForeColor = System.Drawing.Color.Black;
            this.lblNume.Location = new System.Drawing.Point(64, 52);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(71, 26);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume";
            // 
            // txtNume
            // 
            this.txtNume.BackColor = System.Drawing.Color.Snow;
            this.txtNume.Location = new System.Drawing.Point(69, 79);
            this.txtNume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(129, 22);
            this.txtNume.TabIndex = 1;
            this.txtNume.TextChanged += new System.EventHandler(this.txtNume_TextChanged);
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.BackColor = System.Drawing.Color.Snow;
            this.lblPrenume.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenume.ForeColor = System.Drawing.Color.Black;
            this.lblPrenume.Location = new System.Drawing.Point(63, 106);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(112, 26);
            this.lblPrenume.TabIndex = 2;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblDataN
            // 
            this.lblDataN.AutoSize = true;
            this.lblDataN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(204)))));
            this.lblDataN.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataN.ForeColor = System.Drawing.Color.Black;
            this.lblDataN.Location = new System.Drawing.Point(65, 235);
            this.lblDataN.Name = "lblDataN";
            this.lblDataN.Size = new System.Drawing.Size(142, 21);
            this.lblDataN.TabIndex = 3;
            this.lblDataN.Text = "Data Nasterii";
            // 
            // txtPrenume
            // 
            this.txtPrenume.BackColor = System.Drawing.Color.Snow;
            this.txtPrenume.Location = new System.Drawing.Point(69, 139);
            this.txtPrenume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(129, 22);
            this.txtPrenume.TabIndex = 4;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.Snow;
            this.dateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(68, 258);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(179, 22);
            this.dateTimePicker.TabIndex = 5;
            this.dateTimePicker.Value = new System.DateTime(2020, 4, 25, 0, 0, 0, 0);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkRed;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.btnSave.FlatAppearance.BorderSize = 3;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(207)))), ((int)(((byte)(211)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(207)))), ((int)(((byte)(211)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(452, 116);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 39);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "&Salveaza";
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
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(452, 218);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 38);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "&Renunta";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // epMedicNume
            // 
            this.epMedicNume.ContainerControl = this;
            // 
            // epMedicPrenume
            // 
            this.epMedicPrenume.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 42);
            this.panel1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkRed;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(127, 11);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 25);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Introduceti datele medicului";
            // 
            // lblCodCabinet
            // 
            this.lblCodCabinet.AutoSize = true;
            this.lblCodCabinet.BackColor = System.Drawing.Color.Snow;
            this.lblCodCabinet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCodCabinet.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCabinet.ForeColor = System.Drawing.Color.Black;
            this.lblCodCabinet.Location = new System.Drawing.Point(64, 173);
            this.lblCodCabinet.Name = "lblCodCabinet";
            this.lblCodCabinet.Size = new System.Drawing.Size(143, 23);
            this.lblCodCabinet.TabIndex = 11;
            this.lblCodCabinet.Text = "Cod Cabinet";
            this.lblCodCabinet.Click += new System.EventHandler(this.lblCodCabinet_Click);
            // 
            // txtCodCabinet
            // 
            this.txtCodCabinet.BackColor = System.Drawing.Color.Snow;
            this.txtCodCabinet.Location = new System.Drawing.Point(69, 200);
            this.txtCodCabinet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodCabinet.Name = "txtCodCabinet";
            this.txtCodCabinet.Size = new System.Drawing.Size(129, 22);
            this.txtCodCabinet.TabIndex = 12;
            this.txtCodCabinet.TextChanged += new System.EventHandler(this.txtCodCabinet_TextChanged);
            // 
            // epMedicCodCabinet
            // 
            this.epMedicCodCabinet.ContainerControl = this;
            // 
            // AddMedicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(656, 305);
            this.Controls.Add(this.txtCodCabinet);
            this.Controls.Add(this.lblCodCabinet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.lblDataN);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblNume);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddMedicForm";
            this.Text = "AddMedic";
            this.Load += new System.EventHandler(this.AddMedicForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.epMedicNume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMedicPrenume)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMedicCodCabinet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblDataN;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider epMedicNume;
        private System.Windows.Forms.ErrorProvider epMedicPrenume;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtCodCabinet;
        private System.Windows.Forms.Label lblCodCabinet;
        private System.Windows.Forms.ErrorProvider epMedicCodCabinet;
    }
}