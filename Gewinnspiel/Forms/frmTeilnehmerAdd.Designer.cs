namespace Gewinnspiel.Forms
{
    partial class frmTeilnehmerAdd
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
            this.btnAuge = new System.Windows.Forms.Button();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPasswort = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmGeschlecht = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTeilnehmerId = new System.Windows.Forms.Label();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.cbDeaktiviert = new System.Windows.Forms.CheckBox();
            this.txtNachname = new System.Windows.Forms.TextBox();
            this.txtVorname = new System.Windows.Forms.TextBox();
            this.txtTeilnehmerID = new System.Windows.Forms.TextBox();
            this.dtpGeDatum = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAuge
            // 
            this.btnAuge.BackColor = System.Drawing.Color.MediumPurple;
            this.btnAuge.Location = new System.Drawing.Point(391, 266);
            this.btnAuge.Name = "btnAuge";
            this.btnAuge.Size = new System.Drawing.Size(32, 26);
            this.btnAuge.TabIndex = 13;
            this.btnAuge.UseVisualStyleBackColor = false;
            this.btnAuge.Click += new System.EventHandler(this.btnAuge_Click);
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.BackColor = System.Drawing.Color.MediumPurple;
            this.btnAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbbrechen.ForeColor = System.Drawing.Color.White;
            this.btnAbbrechen.Location = new System.Drawing.Point(18, 404);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(405, 41);
            this.btnAbbrechen.TabIndex = 12;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = false;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeichern.ForeColor = System.Drawing.Color.White;
            this.btnSpeichern.Location = new System.Drawing.Point(18, 358);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(405, 40);
            this.btnSpeichern.TabIndex = 11;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = false;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Passwort";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Email";
            // 
            // txtPasswort
            // 
            this.txtPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswort.Location = new System.Drawing.Point(168, 266);
            this.txtPasswort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPasswort.Name = "txtPasswort";
            this.txtPasswort.PasswordChar = '*';
            this.txtPasswort.Size = new System.Drawing.Size(216, 26);
            this.txtPasswort.TabIndex = 8;
            this.txtPasswort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(168, 224);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(255, 26);
            this.txtEmail.TabIndex = 7;
            // 
            // cmGeschlecht
            // 
            this.cmGeschlecht.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmGeschlecht.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmGeschlecht.FormattingEnabled = true;
            this.cmGeschlecht.Items.AddRange(new object[] {
            "m",
            "w",
            "d"});
            this.cmGeschlecht.Location = new System.Drawing.Point(168, 182);
            this.cmGeschlecht.Name = "cmGeschlecht";
            this.cmGeschlecht.Size = new System.Drawing.Size(88, 28);
            this.cmGeschlecht.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Geschlecht";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Geb. Datum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nachname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Vorname";
            // 
            // lblTeilnehmerId
            // 
            this.lblTeilnehmerId.AutoSize = true;
            this.lblTeilnehmerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeilnehmerId.Location = new System.Drawing.Point(40, 17);
            this.lblTeilnehmerId.Name = "lblTeilnehmerId";
            this.lblTeilnehmerId.Size = new System.Drawing.Size(108, 20);
            this.lblTeilnehmerId.TabIndex = 19;
            this.lblTeilnehmerId.Text = "Teilnehmer ID";
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAdmin.Location = new System.Drawing.Point(18, 318);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(73, 24);
            this.cbAdmin.TabIndex = 20;
            this.cbAdmin.Text = "Admin";
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // cbDeaktiviert
            // 
            this.cbDeaktiviert.AutoSize = true;
            this.cbDeaktiviert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDeaktiviert.Location = new System.Drawing.Point(153, 318);
            this.cbDeaktiviert.Name = "cbDeaktiviert";
            this.cbDeaktiviert.Size = new System.Drawing.Size(103, 24);
            this.cbDeaktiviert.TabIndex = 21;
            this.cbDeaktiviert.Text = "Deaktiviert";
            this.cbDeaktiviert.UseVisualStyleBackColor = true;
            // 
            // txtNachname
            // 
            this.txtNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNachname.Location = new System.Drawing.Point(168, 98);
            this.txtNachname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNachname.Name = "txtNachname";
            this.txtNachname.Size = new System.Drawing.Size(255, 26);
            this.txtNachname.TabIndex = 23;
            // 
            // txtVorname
            // 
            this.txtVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVorname.Location = new System.Drawing.Point(168, 56);
            this.txtVorname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.Size = new System.Drawing.Size(255, 26);
            this.txtVorname.TabIndex = 24;
            // 
            // txtTeilnehmerID
            // 
            this.txtTeilnehmerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeilnehmerID.Location = new System.Drawing.Point(168, 14);
            this.txtTeilnehmerID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTeilnehmerID.Name = "txtTeilnehmerID";
            this.txtTeilnehmerID.ReadOnly = true;
            this.txtTeilnehmerID.Size = new System.Drawing.Size(88, 26);
            this.txtTeilnehmerID.TabIndex = 25;
            // 
            // dtpGeDatum
            // 
            this.dtpGeDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGeDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGeDatum.Location = new System.Drawing.Point(168, 138);
            this.dtpGeDatum.Name = "dtpGeDatum";
            this.dtpGeDatum.Size = new System.Drawing.Size(255, 26);
            this.dtpGeDatum.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumPurple;
            this.label7.Location = new System.Drawing.Point(13, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 31);
            this.label7.TabIndex = 27;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumPurple;
            this.label8.Location = new System.Drawing.Point(13, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 31);
            this.label8.TabIndex = 28;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumPurple;
            this.label9.Location = new System.Drawing.Point(13, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 31);
            this.label9.TabIndex = 29;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MediumPurple;
            this.label10.Location = new System.Drawing.Point(13, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 31);
            this.label10.TabIndex = 30;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MediumPurple;
            this.label11.Location = new System.Drawing.Point(13, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 31);
            this.label11.TabIndex = 31;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MediumPurple;
            this.label12.Location = new System.Drawing.Point(13, 265);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 31);
            this.label12.TabIndex = 32;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(318, 319);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 20);
            this.label13.TabIndex = 33;
            this.label13.Text = "Pflichtfelder";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.MediumPurple;
            this.label14.Location = new System.Drawing.Point(291, 315);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 31);
            this.label14.TabIndex = 34;
            this.label14.Text = "*";
            // 
            // frmTeilnehmerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(436, 463);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpGeDatum);
            this.Controls.Add(this.txtTeilnehmerID);
            this.Controls.Add(this.txtVorname);
            this.Controls.Add(this.txtNachname);
            this.Controls.Add(this.cbDeaktiviert);
            this.Controls.Add(this.cbAdmin);
            this.Controls.Add(this.lblTeilnehmerId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmGeschlecht);
            this.Controls.Add(this.btnAuge);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPasswort);
            this.Controls.Add(this.txtEmail);
            this.Name = "frmTeilnehmerAdd";
            this.Load += new System.EventHandler(this.frmTeilnehmerAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAuge;
        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTeilnehmerId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        internal System.Windows.Forms.TextBox txtPasswort;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.ComboBox cmGeschlecht;
        internal System.Windows.Forms.CheckBox cbAdmin;
        internal System.Windows.Forms.CheckBox cbDeaktiviert;
        internal System.Windows.Forms.TextBox txtNachname;
        internal System.Windows.Forms.TextBox txtVorname;
        internal System.Windows.Forms.TextBox txtTeilnehmerID;
        internal System.Windows.Forms.DateTimePicker dtpGeDatum;
    }
}