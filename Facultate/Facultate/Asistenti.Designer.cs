namespace Cabinet_Medical
{
    partial class Asistenti
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPrelDate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMedicamente = new System.Windows.Forms.TextBox();
            this.txtTipReteta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInserare = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.txtModif = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Snow;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Font = new System.Drawing.Font("Stencil", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(81, 57);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(468, 174);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 62;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nume";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prenume";
            this.columnHeader2.Width = 117;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Email";
            this.columnHeader3.Width = 108;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Medicamente";
            this.columnHeader4.Width = 109;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tip Reteta";
            this.columnHeader5.Width = 156;
            // 
            // btnPrelDate
            // 
            this.btnPrelDate.BackColor = System.Drawing.Color.DarkRed;
            this.btnPrelDate.Font = new System.Drawing.Font("Showcard Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrelDate.Location = new System.Drawing.Point(56, 271);
            this.btnPrelDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrelDate.Name = "btnPrelDate";
            this.btnPrelDate.Size = new System.Drawing.Size(114, 51);
            this.btnPrelDate.TabIndex = 1;
            this.btnPrelDate.Text = "Preluare Date";
            this.btnPrelDate.UseVisualStyleBackColor = false;
            this.btnPrelDate.Click += new System.EventHandler(this.btnPrelDate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkRed;
            this.btnUpdate.Font = new System.Drawing.Font("Showcard Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(227, 271);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 43);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Modifica";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtNume
            // 
            this.txtNume.BackColor = System.Drawing.Color.Snow;
            this.txtNume.Location = new System.Drawing.Point(811, 106);
            this.txtNume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(121, 22);
            this.txtNume.TabIndex = 4;
            // 
            // txtPrenume
            // 
            this.txtPrenume.BackColor = System.Drawing.Color.Snow;
            this.txtPrenume.Location = new System.Drawing.Point(811, 158);
            this.txtPrenume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(121, 22);
            this.txtPrenume.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Snow;
            this.txtEmail.Location = new System.Drawing.Point(811, 207);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(121, 22);
            this.txtEmail.TabIndex = 6;
            // 
            // txtMedicamente
            // 
            this.txtMedicamente.BackColor = System.Drawing.Color.Snow;
            this.txtMedicamente.Location = new System.Drawing.Point(811, 251);
            this.txtMedicamente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMedicamente.Name = "txtMedicamente";
            this.txtMedicamente.Size = new System.Drawing.Size(121, 22);
            this.txtMedicamente.TabIndex = 7;
            // 
            // txtTipReteta
            // 
            this.txtTipReteta.BackColor = System.Drawing.Color.Snow;
            this.txtTipReteta.Location = new System.Drawing.Point(811, 292);
            this.txtTipReteta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTipReteta.Name = "txtTipReteta";
            this.txtTipReteta.Size = new System.Drawing.Size(121, 22);
            this.txtTipReteta.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(649, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(649, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Prenume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(649, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(652, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Medicamente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(645, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tip Reteta";
            // 
            // btnInserare
            // 
            this.btnInserare.BackColor = System.Drawing.Color.DarkRed;
            this.btnInserare.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserare.Location = new System.Drawing.Point(748, 336);
            this.btnInserare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInserare.Name = "btnInserare";
            this.btnInserare.Size = new System.Drawing.Size(117, 37);
            this.btnInserare.TabIndex = 15;
            this.btnInserare.Text = "Inserare";
            this.btnInserare.UseVisualStyleBackColor = false;
            this.btnInserare.Click += new System.EventHandler(this.btnInserare_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.BackColor = System.Drawing.Color.DarkRed;
            this.btnSterge.Font = new System.Drawing.Font("Showcard Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSterge.ForeColor = System.Drawing.Color.Black;
            this.btnSterge.Location = new System.Drawing.Point(423, 271);
            this.btnSterge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(114, 41);
            this.btnSterge.TabIndex = 16;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = false;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // txtModif
            // 
            this.txtModif.BackColor = System.Drawing.Color.Snow;
            this.txtModif.Location = new System.Drawing.Point(437, 351);
            this.txtModif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModif.Name = "txtModif";
            this.txtModif.Size = new System.Drawing.Size(112, 22);
            this.txtModif.TabIndex = 17;
            // 
            // Asistenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.CancelButton = this.btnInserare;
            this.ClientSize = new System.Drawing.Size(1069, 396);
            this.Controls.Add(this.txtModif);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnInserare);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTipReteta);
            this.Controls.Add(this.txtMedicamente);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnPrelDate);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Asistenti";
            this.ShowInTaskbar = false;
            this.Text = "Asistenti";
            this.Load += new System.EventHandler(this.Asistenti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnPrelDate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMedicamente;
        private System.Windows.Forms.TextBox txtTipReteta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInserare;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.TextBox txtModif;
    }
}