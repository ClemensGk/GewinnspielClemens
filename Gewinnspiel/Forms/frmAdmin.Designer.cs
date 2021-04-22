namespace Gewinnspiel.Forms
{
    partial class frmAdmin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gewinnspielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hinzufügenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teilnehmerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teilnehmerlisteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearebeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deaktivierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einemGewinnpielHinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvGewinnspiele = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsGewinnspiel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hinzufügenToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.teilnehmerHinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvTeilnehmer = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsTeilnehmer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.teilnehmerEntfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAktive = new System.Windows.Forms.RadioButton();
            this.rbAbgeschlossen = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.cmsGewinnspiel.SuspendLayout();
            this.cmsTeilnehmer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gewinnspielToolStripMenuItem,
            this.teilnehmerToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1439, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gewinnspielToolStripMenuItem
            // 
            this.gewinnspielToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hinzufügenToolStripMenuItem1,
            this.bearbeitenToolStripMenuItem});
            this.gewinnspielToolStripMenuItem.Name = "gewinnspielToolStripMenuItem";
            this.gewinnspielToolStripMenuItem.Size = new System.Drawing.Size(107, 25);
            this.gewinnspielToolStripMenuItem.Text = "Gewinnspiel";
            // 
            // hinzufügenToolStripMenuItem1
            // 
            this.hinzufügenToolStripMenuItem1.Name = "hinzufügenToolStripMenuItem1";
            this.hinzufügenToolStripMenuItem1.Size = new System.Drawing.Size(160, 26);
            this.hinzufügenToolStripMenuItem1.Text = "Hinzufügen";
            this.hinzufügenToolStripMenuItem1.Click += new System.EventHandler(this.hinzufügenToolStripMenuItem1_Click);
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            this.bearbeitenToolStripMenuItem.Click += new System.EventHandler(this.bearbeitenToolStripMenuItem_Click);
            // 
            // teilnehmerToolStripMenuItem
            // 
            this.teilnehmerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teilnehmerlisteToolStripMenuItem,
            this.hinzufügenToolStripMenuItem,
            this.bearebeitenToolStripMenuItem,
            this.deaktivierenToolStripMenuItem,
            this.einemGewinnpielHinzufügenToolStripMenuItem});
            this.teilnehmerToolStripMenuItem.Name = "teilnehmerToolStripMenuItem";
            this.teilnehmerToolStripMenuItem.Size = new System.Drawing.Size(98, 25);
            this.teilnehmerToolStripMenuItem.Text = "Teilnehmer";
            // 
            // teilnehmerlisteToolStripMenuItem
            // 
            this.teilnehmerlisteToolStripMenuItem.Name = "teilnehmerlisteToolStripMenuItem";
            this.teilnehmerlisteToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.teilnehmerlisteToolStripMenuItem.Text = "Teilnehmerliste";
            this.teilnehmerlisteToolStripMenuItem.Click += new System.EventHandler(this.teilnehmerlisteToolStripMenuItem_Click);
            // 
            // hinzufügenToolStripMenuItem
            // 
            this.hinzufügenToolStripMenuItem.Name = "hinzufügenToolStripMenuItem";
            this.hinzufügenToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.hinzufügenToolStripMenuItem.Text = "Hinzufügen";
            this.hinzufügenToolStripMenuItem.Click += new System.EventHandler(this.hinzufügenToolStripMenuItem_Click);
            // 
            // bearebeitenToolStripMenuItem
            // 
            this.bearebeitenToolStripMenuItem.Name = "bearebeitenToolStripMenuItem";
            this.bearebeitenToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.bearebeitenToolStripMenuItem.Text = "Bearebeiten";
            this.bearebeitenToolStripMenuItem.Click += new System.EventHandler(this.bearebeitenToolStripMenuItem_Click);
            // 
            // deaktivierenToolStripMenuItem
            // 
            this.deaktivierenToolStripMenuItem.Name = "deaktivierenToolStripMenuItem";
            this.deaktivierenToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.deaktivierenToolStripMenuItem.Text = "De/aktivieren";
            this.deaktivierenToolStripMenuItem.Click += new System.EventHandler(this.deaktivierenToolStripMenuItem_Click);
            // 
            // einemGewinnpielHinzufügenToolStripMenuItem
            // 
            this.einemGewinnpielHinzufügenToolStripMenuItem.Name = "einemGewinnpielHinzufügenToolStripMenuItem";
            this.einemGewinnpielHinzufügenToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.einemGewinnpielHinzufügenToolStripMenuItem.Text = "einem Gewinnpiel hinzufügen";
            this.einemGewinnpielHinzufügenToolStripMenuItem.Click += new System.EventHandler(this.einemGewinnpielHinzufügenToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(71, 25);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // lvGewinnspiele
            // 
            this.lvGewinnspiele.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16});
            this.lvGewinnspiele.ContextMenuStrip = this.cmsGewinnspiel;
            this.lvGewinnspiele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvGewinnspiele.HideSelection = false;
            this.lvGewinnspiele.Location = new System.Drawing.Point(12, 87);
            this.lvGewinnspiele.Name = "lvGewinnspiele";
            this.lvGewinnspiele.Size = new System.Drawing.Size(633, 297);
            this.lvGewinnspiele.TabIndex = 1;
            this.lvGewinnspiele.UseCompatibleStateImageBehavior = false;
            this.lvGewinnspiele.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Bild";
            this.columnHeader10.Width = 53;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Spiel ID";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader11.Width = 84;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Bezeichnung";
            this.columnHeader12.Width = 120;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Gewinn";
            this.columnHeader13.Width = 80;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Wert";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader14.Width = 70;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "ausgelost";
            this.columnHeader15.Width = 100;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Bildpfad";
            this.columnHeader16.Width = 87;
            // 
            // cmsGewinnspiel
            // 
            this.cmsGewinnspiel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsGewinnspiel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hinzufügenToolStripMenuItem2,
            this.bearbeitenToolStripMenuItem1,
            this.teilnehmerHinzufügenToolStripMenuItem});
            this.cmsGewinnspiel.Name = "cmsGewinnspiel";
            this.cmsGewinnspiel.Size = new System.Drawing.Size(241, 82);
            // 
            // hinzufügenToolStripMenuItem2
            // 
            this.hinzufügenToolStripMenuItem2.Name = "hinzufügenToolStripMenuItem2";
            this.hinzufügenToolStripMenuItem2.Size = new System.Drawing.Size(240, 26);
            this.hinzufügenToolStripMenuItem2.Text = "Hinzufügen";
            this.hinzufügenToolStripMenuItem2.Click += new System.EventHandler(this.hinzufügenToolStripMenuItem2_Click);
            // 
            // bearbeitenToolStripMenuItem1
            // 
            this.bearbeitenToolStripMenuItem1.Name = "bearbeitenToolStripMenuItem1";
            this.bearbeitenToolStripMenuItem1.Size = new System.Drawing.Size(240, 26);
            this.bearbeitenToolStripMenuItem1.Text = "Bearbeiten";
            this.bearbeitenToolStripMenuItem1.Click += new System.EventHandler(this.bearbeitenToolStripMenuItem1_Click);
            // 
            // teilnehmerHinzufügenToolStripMenuItem
            // 
            this.teilnehmerHinzufügenToolStripMenuItem.Name = "teilnehmerHinzufügenToolStripMenuItem";
            this.teilnehmerHinzufügenToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.teilnehmerHinzufügenToolStripMenuItem.Text = "Teilnehmer Hinzufügen";
            // 
            // lvTeilnehmer
            // 
            this.lvTeilnehmer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvTeilnehmer.ContextMenuStrip = this.cmsTeilnehmer;
            this.lvTeilnehmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTeilnehmer.HideSelection = false;
            this.lvTeilnehmer.Location = new System.Drawing.Point(652, 87);
            this.lvTeilnehmer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvTeilnehmer.Name = "lvTeilnehmer";
            this.lvTeilnehmer.Size = new System.Drawing.Size(777, 297);
            this.lvTeilnehmer.TabIndex = 2;
            this.lvTeilnehmer.UseCompatibleStateImageBehavior = false;
            this.lvTeilnehmer.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Vorname";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nachname";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Geb. Datum";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "geschlecht";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "email";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "deaktiviert";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "admin";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Spiele";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmsTeilnehmer
            // 
            this.cmsTeilnehmer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsTeilnehmer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teilnehmerEntfernenToolStripMenuItem});
            this.cmsTeilnehmer.Name = "cmsTeilnehmer";
            this.cmsTeilnehmer.Size = new System.Drawing.Size(228, 30);
            // 
            // teilnehmerEntfernenToolStripMenuItem
            // 
            this.teilnehmerEntfernenToolStripMenuItem.Name = "teilnehmerEntfernenToolStripMenuItem";
            this.teilnehmerEntfernenToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.teilnehmerEntfernenToolStripMenuItem.Text = "Teilnehmer entfernen";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAktive);
            this.groupBox1.Controls.Add(this.rbAbgeschlossen);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 45);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rbAktive
            // 
            this.rbAktive.AutoSize = true;
            this.rbAktive.Location = new System.Drawing.Point(291, 16);
            this.rbAktive.Name = "rbAktive";
            this.rbAktive.Size = new System.Drawing.Size(167, 24);
            this.rbAktive.TabIndex = 1;
            this.rbAktive.TabStop = true;
            this.rbAktive.Text = "aktive Gewinnspiele";
            this.rbAktive.UseVisualStyleBackColor = true;
            this.rbAktive.CheckedChanged += new System.EventHandler(this.rbAktive_CheckedChanged);
            // 
            // rbAbgeschlossen
            // 
            this.rbAbgeschlossen.AutoSize = true;
            this.rbAbgeschlossen.Location = new System.Drawing.Point(6, 16);
            this.rbAbgeschlossen.Name = "rbAbgeschlossen";
            this.rbAbgeschlossen.Size = new System.Drawing.Size(244, 24);
            this.rbAbgeschlossen.TabIndex = 0;
            this.rbAbgeschlossen.TabStop = true;
            this.rbAbgeschlossen.Text = "Abgeschlossene Gewinnspiele";
            this.rbAbgeschlossen.UseVisualStyleBackColor = true;
            this.rbAbgeschlossen.CheckedChanged += new System.EventHandler(this.rbAbgeschlossen_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(648, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Teilnehmer des ausgewählten Gewinnspieles";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1439, 394);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvTeilnehmer);
            this.Controls.Add(this.lvGewinnspiele);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cmsGewinnspiel.ResumeLayout(false);
            this.cmsTeilnehmer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gewinnspielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teilnehmerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teilnehmerlisteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hinzufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearebeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deaktivierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einemGewinnpielHinzufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ListView lvGewinnspiele;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ListView lvTeilnehmer;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAktive;
        private System.Windows.Forms.RadioButton rbAbgeschlossen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem hinzufügenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsGewinnspiel;
        private System.Windows.Forms.ToolStripMenuItem hinzufügenToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem teilnehmerHinzufügenToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsTeilnehmer;
        private System.Windows.Forms.ToolStripMenuItem teilnehmerEntfernenToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader16;
    }
}