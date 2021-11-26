namespace Cabinet_Medical
{
    partial class AddRetetaForm
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
            this.txtMedicamente = new System.Windows.Forms.TextBox();
            this.cbTipReteta = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.epMedicamente = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTipReteta = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.epMedicamente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTipReteta)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMedicamente
            // 
            this.txtMedicamente.BackColor = System.Drawing.Color.Snow;
            this.txtMedicamente.Location = new System.Drawing.Point(35, 103);
            this.txtMedicamente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMedicamente.Name = "txtMedicamente";
            this.txtMedicamente.Size = new System.Drawing.Size(249, 22);
            this.txtMedicamente.TabIndex = 0;
            this.txtMedicamente.TextChanged += new System.EventHandler(this.txtMedicamente_TextChanged);
            // 
            // cbTipReteta
            // 
            this.cbTipReteta.BackColor = System.Drawing.Color.Snow;
            this.cbTipReteta.FormattingEnabled = true;
            this.cbTipReteta.Items.AddRange(new object[] {
            "Reteta magistrala",
            "Reteta oficinala",
            "Reteta tipizata"});
            this.cbTipReteta.Location = new System.Drawing.Point(35, 164);
            this.cbTipReteta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTipReteta.Name = "cbTipReteta";
            this.cbTipReteta.Size = new System.Drawing.Size(173, 24);
            this.cbTipReteta.TabIndex = 1;
            this.cbTipReteta.SelectedIndexChanged += new System.EventHandler(this.cbTipReteta_SelectedIndexChanged);
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
            this.btnSave.Location = new System.Drawing.Point(381, 73);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 33);
            this.btnSave.TabIndex = 2;
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
            this.btnCancel.Location = new System.Drawing.Point(381, 164);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 38);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Renunta";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // epMedicamente
            // 
            this.epMedicamente.ContainerControl = this;
            // 
            // epTipReteta
            // 
            this.epTipReteta.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(53, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Medicamente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(53, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tip Reteta";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 44);
            this.panel1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkRed;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(81, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(377, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Introduceti datele retetei :";
            // 
            // AddRetetaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(548, 270);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbTipReteta);
            this.Controls.Add(this.txtMedicamente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddRetetaForm";
            this.Text = "AddRetetaForm";
            this.Load += new System.EventHandler(this.AddRetetaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epMedicamente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTipReteta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMedicamente;
        private System.Windows.Forms.ComboBox cbTipReteta;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider epMedicamente;
        private System.Windows.Forms.ErrorProvider epTipReteta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
    }
}