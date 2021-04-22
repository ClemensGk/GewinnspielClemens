namespace Gewinnspiel.Forms
{
    partial class frmLogin
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPasswort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEinloggen = new System.Windows.Forms.Button();
            this.btnRegistrieren = new System.Windows.Forms.Button();
            this.btnAuge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(137, 23);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(255, 26);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.Text = "clemens.linhart@gmx.at";
            // 
            // txtPasswort
            // 
            this.txtPasswort.Location = new System.Drawing.Point(137, 74);
            this.txtPasswort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPasswort.Name = "txtPasswort";
            this.txtPasswort.PasswordChar = '*';
            this.txtPasswort.Size = new System.Drawing.Size(216, 26);
            this.txtPasswort.TabIndex = 1;
            this.txtPasswort.Text = "2704";
            this.txtPasswort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPasswort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPasswort_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Passwort";
            // 
            // btnEinloggen
            // 
            this.btnEinloggen.BackColor = System.Drawing.Color.MediumPurple;
            this.btnEinloggen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEinloggen.ForeColor = System.Drawing.Color.White;
            this.btnEinloggen.Location = new System.Drawing.Point(22, 130);
            this.btnEinloggen.Name = "btnEinloggen";
            this.btnEinloggen.Size = new System.Drawing.Size(370, 40);
            this.btnEinloggen.TabIndex = 4;
            this.btnEinloggen.Text = "Einloggen";
            this.btnEinloggen.UseVisualStyleBackColor = false;
            this.btnEinloggen.Click += new System.EventHandler(this.btnEinloggen_Click_1);
            // 
            // btnRegistrieren
            // 
            this.btnRegistrieren.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRegistrieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrieren.ForeColor = System.Drawing.Color.White;
            this.btnRegistrieren.Location = new System.Drawing.Point(22, 176);
            this.btnRegistrieren.Name = "btnRegistrieren";
            this.btnRegistrieren.Size = new System.Drawing.Size(370, 41);
            this.btnRegistrieren.TabIndex = 5;
            this.btnRegistrieren.Text = "Registrieren";
            this.btnRegistrieren.UseVisualStyleBackColor = false;
            this.btnRegistrieren.Click += new System.EventHandler(this.btnRegistrieren_Click_1);
            // 
            // btnAuge
            // 
            this.btnAuge.BackColor = System.Drawing.Color.MediumPurple;
            this.btnAuge.Location = new System.Drawing.Point(360, 74);
            this.btnAuge.Name = "btnAuge";
            this.btnAuge.Size = new System.Drawing.Size(32, 26);
            this.btnAuge.TabIndex = 6;
            this.btnAuge.UseVisualStyleBackColor = false;
            this.btnAuge.Click += new System.EventHandler(this.btnAuge_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 236);
            this.Controls.Add(this.btnAuge);
            this.Controls.Add(this.btnRegistrieren);
            this.Controls.Add(this.btnEinloggen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPasswort);
            this.Controls.Add(this.txtEmail);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLogin";
            this.Text = "Login Gewinnspiel";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPasswort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEinloggen;
        private System.Windows.Forms.Button btnRegistrieren;
        private System.Windows.Forms.Button btnAuge;
    }
}