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
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Security.Cryptography;

namespace Gewinnspiel.Forms
{
    public partial class frmLogin : Form
    {
        internal static frmLogin frmLog;
        public frmLogin()
        {
            frmLog = this;
            InitializeComponent();
        }
        #region Variablen
        internal string pwCode;
        internal bool foundUser;
        internal Teilnehmer activeUser;

        internal List<Teilnehmer> TeilnehmerListe;
        internal List<Spiel> gewinnspielListe;

        internal XmlSerializer serializerTeilnehmer;
        internal XmlSerializer serializerSpiele;

        internal frmAdmin frmAd;
        internal frmTeilnehmer frmTeiln;
        #endregion

        #region From
        private void frmLogin_Load(object sender, EventArgs e)
        {
            TeilnehmerListe = new List<Teilnehmer>();
            gewinnspielListe = new List<Spiel>();

            serializerTeilnehmer = new XmlSerializer(TeilnehmerListe.GetType());
            serializerSpiele = new XmlSerializer(gewinnspielListe.GetType());

            deserialisierenTeiln();
            deserialisierenSpiel();
        }
        #endregion

        #region Methoden
        #region Serialisieren/Deserialisieren
        internal void serialisierenTeiln()
        {
            try
            {
                FileStream fs = new FileStream("Teilnehmer.xml", FileMode.Create, FileAccess.Write, FileShare.None);
                serializerTeilnehmer.Serialize(fs, TeilnehmerListe);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Serialisierender der Teilnehmer: " + ex.Message);
            }
        }

        internal void serialisierenSpiel()
        {
            try
            {
                FileStream fs = new FileStream("Gewinnspiele.xml", FileMode.Create, FileAccess.Write, FileShare.None);
                serializerSpiele.Serialize(fs, gewinnspielListe);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Serialisierender der Gewinnspiele: " + ex.Message);
            }
        }

        internal void deserialisierenTeiln()
        {
            try
            {
                FileStream fs = new FileStream("Teilnehmer.xml", FileMode.Open, FileAccess.Read, FileShare.None);
                TeilnehmerListe = (List<Teilnehmer>)serializerTeilnehmer.Deserialize(fs);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Deserialisierender der Teilnehmer: " + ex.Message);
            }
        }

        internal void deserialisierenSpiel()
        {
            try
            {
                FileStream fs = new FileStream("Gewinnspiele.xml", FileMode.Open, FileAccess.Read, FileShare.None);
                gewinnspielListe = (List<Spiel>)serializerSpiele.Deserialize(fs);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Deserialisierender der Gewinnspiele: " + ex.Message);
            }
        }
        #endregion

        internal String verschluesselnSHA512(string text)
        {
            string temp;
            SHA512 sha512 = new SHA512CryptoServiceProvider();
            byte[] textToHash = Encoding.Default.GetBytes(text);
            byte[] result = sha512.ComputeHash(textToHash);
            return temp=System.BitConverter.ToString(result);
        }
        
        private void login()
        {
            pwCode = verschluesselnSHA512(txtPasswort.Text);
            foreach(Teilnehmer t in TeilnehmerListe)
            {
                if(t.Email.Equals(txtEmail.Text) && t.Passwort.Equals(pwCode))
                {
                    if(t.Deaktiviert==true)
                    {
                        MessageBox.Show("Ihr Accoun ist deaktivert, wenden Sie sich an den Administrator um ihn zu aktivieren!");
                        return;
                    }
                    foundUser = true;
                    activeUser = t;
                    txtEmail.Clear();
                    txtPasswort.Clear();
                    
                    if(t.Admin)
                    {
                        frmAd = new frmAdmin();
                        frmAd.Text = "Du bist eingeloggt als " + t.Vorname + " " + t.Nachname + ", du bist Admin";
                        frmAd.ShowDialog();
                    }
                    else //Teilnehmer
                    {
                        frmTeiln = new frmTeilnehmer();
                        frmTeiln.Text = "Du bist eingeloggt als " + t.Vorname + " " + t.Nachname;
                        frmTeiln.ShowDialog();
                    }
                    break;
                }
            }
            if(foundUser==false)
            {
                MessageBox.Show("Falsche Email-Adresse oder falsches Passwort!");
                return;
            }
            else
            {
                foundUser = false;
                activeUser = null;
            }
        }
        #endregion
        
        private void btnAuge_Click(object sender, EventArgs e)
        {
            if (txtPasswort.PasswordChar == '*')
                txtPasswort.PasswordChar = '\0';
            else
                txtPasswort.PasswordChar = '*';
        }

        private void txtPasswort_KeyDown(object sender, KeyEventArgs e)
        {
            //login();
        }

        private void btnEinloggen_Click_1(object sender, EventArgs e)
        {
            login();
        }

        private void btnRegistrieren_Click_1(object sender, EventArgs e)
        {
            if (txtEmail.Text.Equals("") || txtPasswort.Equals(""))
            {
                MessageBox.Show("Bitte füllen Sie sowohl Benutzer als auch Passwort aus!");
                return;
            }
            foreach (Teilnehmer t in TeilnehmerListe)
            {
                if (txtEmail.Text.Equals(t.Email))
                {
                    MessageBox.Show("Diese Email-Addresse ist bereits registriert!");
                    return;
                }
            }
            frmTeilnehmerAdd frmReg = new frmTeilnehmerAdd();
            frmReg.Text = "Registrierung";
            frmReg.txtEmail.Text = txtEmail.Text;
            frmReg.txtPasswort.Text = txtPasswort.Text;
            frmReg.ShowDialog();
        }
    }
}
