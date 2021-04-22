namespace Gewinnspiel.Forms
{
    partial class frmGewinnspiel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbAusgelost = new System.Windows.Forms.CheckBox();
            this.txtGewinnspielID = new System.Windows.Forms.TextBox();
            this.txtBezeichnung = new System.Windows.Forms.TextBox();
            this.txtGewinn = new System.Windows.Forms.TextBox();
            this.txtWert = new System.Windows.Forms.TextBox();
            this.txtBildpfad = new System.Windows.Forms.TextBox();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "GewinnspielID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bezeichnung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gewinn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wert";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 205);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Bildpfad";
            // 
            // cbAusgelost
            // 
            this.cbAusgelost.AutoSize = true;
            this.cbAusgelost.Location = new System.Drawing.Point(179, 246);
            this.cbAusgelost.Name = "cbAusgelost";
            this.cbAusgelost.Size = new System.Drawing.Size(97, 24);
            this.cbAusgelost.TabIndex = 6;
            this.cbAusgelost.Text = "ausgelost";
            this.cbAusgelost.UseVisualStyleBackColor = true;
            // 
            // txtGewinnspielID
            // 
            this.txtGewinnspielID.Location = new System.Drawing.Point(179, 21);
            this.txtGewinnspielID.Name = "txtGewinnspielID";
            this.txtGewinnspielID.ReadOnly = true;
            this.txtGewinnspielID.Size = new System.Drawing.Size(103, 26);
            this.txtGewinnspielID.TabIndex = 7;
            // 
            // txtBezeichnung
            // 
            this.txtBezeichnung.Location = new System.Drawing.Point(179, 64);
            this.txtBezeichnung.Name = "txtBezeichnung";
            this.txtBezeichnung.Size = new System.Drawing.Size(234, 26);
            this.txtBezeichnung.TabIndex = 8;
            // 
            // txtGewinn
            // 
            this.txtGewinn.Location = new System.Drawing.Point(179, 110);
            this.txtGewinn.Name = "txtGewinn";
            this.txtGewinn.Size = new System.Drawing.Size(234, 26);
            this.txtGewinn.TabIndex = 9;
            // 
            // txtWert
            // 
            this.txtWert.Location = new System.Drawing.Point(179, 156);
            this.txtWert.Name = "txtWert";
            this.txtWert.Size = new System.Drawing.Size(234, 26);
            this.txtWert.TabIndex = 10;
            this.txtWert.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBildpfad
            // 
            this.txtBildpfad.Location = new System.Drawing.Point(179, 202);
            this.txtBildpfad.Name = "txtBildpfad";
            this.txtBildpfad.ReadOnly = true;
            this.txtBildpfad.Size = new System.Drawing.Size(234, 26);
            this.txtBildpfad.TabIndex = 11;
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.BackColor = System.Drawing.Color.MediumPurple;
            this.btnAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbbrechen.ForeColor = System.Drawing.Color.White;
            this.btnAbbrechen.Location = new System.Drawing.Point(179, 354);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(234, 49);
            this.btnAbbrechen.TabIndex = 14;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = false;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeichern.ForeColor = System.Drawing.Color.White;
            this.btnSpeichern.Location = new System.Drawing.Point(179, 290);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(234, 48);
            this.btnSpeichern.TabIndex = 13;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = false;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(17, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // frmGewinnspiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(432, 415);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.txtBildpfad);
            this.Controls.Add(this.txtWert);
            this.Controls.Add(this.txtGewinn);
            this.Controls.Add(this.txtBezeichnung);
            this.Controls.Add(this.txtGewinnspielID);
            this.Controls.Add(this.cbAusgelost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGewinnspiel";
            this.Text = "frmGewinnspiel";
            this.Load += new System.EventHandler(this.frmGewinnspiel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.Button btnSpeichern;
        internal System.Windows.Forms.CheckBox cbAusgelost;
        internal System.Windows.Forms.TextBox txtGewinnspielID;
        internal System.Windows.Forms.TextBox txtBezeichnung;
        internal System.Windows.Forms.TextBox txtGewinn;
        internal System.Windows.Forms.TextBox txtWert;
        internal System.Windows.Forms.TextBox txtBildpfad;
        internal System.Windows.Forms.PictureBox pictureBox1;
    }
}