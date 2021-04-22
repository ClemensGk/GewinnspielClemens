using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gewinnspiel.Classes;
using Gewinnspiel.Forms;

namespace Gewinnspiel.Forms
{
    public partial class frmTeilnehmerAdd : Form
    {
        public frmTeilnehmerAdd()
        {
            InitializeComponent();
        }

        #region Variablen
        DateTime minus16Y;
        #endregion

        private void frmTeilnehmerAdd_Load(object sender, EventArgs e)
        {
            if(frmLogin.frmLog.activeUser==null) //Registrieren
            {
                cbAdmin.Visible = false;
                cbDeaktiviert.Visible = false;
                txtTeilnehmerID.Text = Teilnehmer.Autonum.ToString();
            }
            else //Bearbeiten
            {
                if(frmLogin.frmLog.activeUser.Admin) //ist Admin
                {
                    cbAdmin.Visible = true;
                    cbDeaktiviert.Visible = true;
                }
                else // Ist "nur" Teilnehmer
                {
                    cbAdmin.Visible = false;
                    cbDeaktiviert.Visible = false;
                }
            }
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if(txtNachname.Text.Equals("")|| txtVorname.Equals("")||txtEmail.Equals(""))
            {
                MessageBox.Show("Bitte füllen Sie sowohl Zuname, Vorname als auch Email aus!");
                return;
            }
            if(frmLogin.frmLog.activeUser==null && txtPasswort.Text.Equals(""))
            {
                MessageBox.Show("Bitte geben Sie ein Passwort ein!");
                return;
            }
            if(cmGeschlecht.SelectedIndex==-1) //kein Geschlecht ausgewählt
            {
                MessageBox.Show("Bitte wählen Sie das Geschlecht aus!");
                return;
            }

            minus16Y = DateTime.Now.AddYears(-16);
            if(dtpGeDatum.Value.Date > minus16Y)
            {
                MessageBox.Show("Bitte wählen Sie Ihr Geburtsdatum aus, Sie müssen mindestens 16 Jahre alt sein!");
                return;
            }

            if(frmLogin.frmLog.activeUser==null) //Neuanlage
            {
                Teilnehmer t = new Teilnehmer();
                t.Nachname = txtNachname.Text;
                t.Vorname = txtVorname.Text;
                t.Passwort = frmLogin.frmLog.verschluesselnSHA512(txtPasswort.Text);
                t.Email = txtEmail.Text;
                t.GebDatum = dtpGeDatum.Value.Date;
                t.Geschlecht = Convert.ToChar(cmGeschlecht.Text);
                t.Admin = false;
                t.Deaktiviert = false;
                frmLogin.frmLog.TeilnehmerListe.Add(t);
                MessageBox.Show("Registrierung erfolgreich!");
            }
            else //Bearbeiten
            {
                
            }
            frmLogin.frmLog.serialisierenTeiln();
            this.Close();
        }

        private void btnAuge_Click(object sender, EventArgs e)
        {
            if (txtPasswort.PasswordChar == '*')
                txtPasswort.PasswordChar = '\0';
            else
                txtPasswort.PasswordChar = '*';
        }
    }
}
