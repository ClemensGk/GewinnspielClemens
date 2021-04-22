namespace Gewinnspiel.Forms
{
    partial class frmTeilnehmerListe
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.teilnehmerHinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teilnehmerBearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teilnehmerDeaktivierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teilnehmerZumGewinnspielHinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 14);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(930, 381);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teilnehmerHinzufügenToolStripMenuItem,
            this.teilnehmerBearbeitenToolStripMenuItem,
            this.teilnehmerDeaktivierenToolStripMenuItem,
            this.teilnehmerZumGewinnspielHinzufügenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(362, 130);
            // 
            // teilnehmerHinzufügenToolStripMenuItem
            // 
            this.teilnehmerHinzufügenToolStripMenuItem.Name = "teilnehmerHinzufügenToolStripMenuItem";
            this.teilnehmerHinzufügenToolStripMenuItem.Size = new System.Drawing.Size(361, 26);
            this.teilnehmerHinzufügenToolStripMenuItem.Text = "Teilnehmer hinzufügen";
            this.teilnehmerHinzufügenToolStripMenuItem.Click += new System.EventHandler(this.teilnehmerHinzufügenToolStripMenuItem_Click);
            // 
            // teilnehmerBearbeitenToolStripMenuItem
            // 
            this.teilnehmerBearbeitenToolStripMenuItem.Name = "teilnehmerBearbeitenToolStripMenuItem";
            this.teilnehmerBearbeitenToolStripMenuItem.Size = new System.Drawing.Size(361, 26);
            this.teilnehmerBearbeitenToolStripMenuItem.Text = "Teilnehmer bearbeiten";
            this.teilnehmerBearbeitenToolStripMenuItem.Click += new System.EventHandler(this.teilnehmerBearbeitenToolStripMenuItem_Click);
            // 
            // teilnehmerDeaktivierenToolStripMenuItem
            // 
            this.teilnehmerDeaktivierenToolStripMenuItem.Name = "teilnehmerDeaktivierenToolStripMenuItem";
            this.teilnehmerDeaktivierenToolStripMenuItem.Size = new System.Drawing.Size(361, 26);
            this.teilnehmerDeaktivierenToolStripMenuItem.Text = "Teilnehmer de/aktivieren";
            this.teilnehmerDeaktivierenToolStripMenuItem.Click += new System.EventHandler(this.teilnehmerDeaktivierenToolStripMenuItem_Click);
            // 
            // teilnehmerZumGewinnspielHinzufügenToolStripMenuItem
            // 
            this.teilnehmerZumGewinnspielHinzufügenToolStripMenuItem.Name = "teilnehmerZumGewinnspielHinzufügenToolStripMenuItem";
            this.teilnehmerZumGewinnspielHinzufügenToolStripMenuItem.Size = new System.Drawing.Size(361, 26);
            this.teilnehmerZumGewinnspielHinzufügenToolStripMenuItem.Text = "Teilnehmer zum Gewinnspiel hinzufügen";
            // 
            // frmTeilnehmerListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(956, 409);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTeilnehmerListe";
            this.Text = "frmTeilnehmerListe";
            this.Load += new System.EventHandler(this.frmTeilnehmerListe_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem teilnehmerHinzufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teilnehmerBearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teilnehmerDeaktivierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teilnehmerZumGewinnspielHinzufügenToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}