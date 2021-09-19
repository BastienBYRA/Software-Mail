using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Mail
{

    public partial class Form2 : Form
    {

        string fichierContacts = @"..\..\Contact\contact.txt";

        public Form2()
        {
            InitializeComponent();
            int nbCols = 4;
            dgvContact.ColumnCount = nbCols;

            dgvContact.ColumnHeadersVisible = true;
            dgvContact.Columns[0].HeaderText = "ID";
            dgvContact.Columns[1].HeaderText = "Nom";
            dgvContact.Columns[2].HeaderText = "Prenom";
            dgvContact.Columns[3].HeaderText = "Adresse Mail";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            remplir();
        }

        public void remplir()
        {
            if (File.Exists(fichierContacts))
            {
                dgvContact.RowCount = 0;
                dgvContact.ColumnCount = 4;
                int i = 0;
                string[] Contacts = File.ReadAllLines(fichierContacts);

                foreach (string unContact in Contacts)
                {
                    dgvContact.Rows.Add();
                    string[] contact = unContact.Split(';');
                    for (int j = 0; j < 4; j++)
                    {
                        dgvContact[j, i].Value = contact[j];
                    }
                    //dgvContact.Rows.Add(contact[0], contact[1], contact[2]);
                    i++;
                }
            }
        }


        private void chargement_Contacts()
        {
            //if (File.Exists(fichierContacts))
            //{
            //    string[] Contacts = File.ReadAllLines(fichierContacts);

            //    foreach (string unContact in Contacts)
            //    {
            //        string[] contact = unContact.Split(';');
            //        dgvContact.Rows.Add(contact[0], contact[1], contact[2]);
            //    }
            //}
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (tbxMail.Text != "" && tbxNom.Text != "" && tbxPrenom.Text != "")
            {
                var lineCount = File.ReadLines(fichierContacts).Count();

                string ligne;
                StreamWriter contactSW;

                if (!File.Exists(fichierContacts))
                {
                    contactSW = new StreamWriter(fichierContacts);
                }
                else
                {
                    contactSW = File.AppendText(fichierContacts);
                }

                ligne = lineCount + 1 + ";" + tbxNom.Text + ";" + tbxPrenom.Text + ";" + tbxMail.Text;

                contactSW.WriteLine(ligne);

                contactSW.Close();
                contactSW.Dispose();
                remplir();
            }
            else
            {
                MessageBox.Show("Manque l'une des trois données suivantes ; Nom, Prénom ou Mail. Veuillez remplir toutes les cases");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //////File.ReadAllLines(fichierContacts);
            //////for (int i = 0; i < dgvContact.Rows.Count; i++)
            //////{
            //////    dgvContact.Rows.RemoveAt(i);
            //////}
            ////var lineNumber = 1;

            ////while (lineNumber != Convert.ToInt32(tbxID.Text))
            ////{
            ////    lineNumber = File.ReadLines(fichierContacts).Count();
            ////}
            ////if (lineNumber == Convert.ToInt32(tbxID.Text))
            ////{
            ////    dgvContact.Rows.RemoveAt(lineNumber);
            ////}   




            {
                String fichierContact2 = @"..\..\Contact\contact2.txt";
                String ligne;
                Boolean trouve = false;
                StreamReader contactSR = new StreamReader(fichierContacts);
                StreamWriter contactSW = new StreamWriter(fichierContact2);

                while (!contactSR.EndOfStream)
                {
                    ligne = contactSR.ReadLine();
                    String[] tabLigne = ligne.Split(';');
                    if (tabLigne[0] != tbxID.Text)
                    {
                        contactSW.WriteLine(ligne);
                    }
                    else
                    {
                        trouve = true;
                    }
                }

                contactSR.Close();
                contactSR.Dispose();
                contactSW.Close();
                contactSW.Dispose();
                

                File.Replace(fichierContact2, fichierContacts, @"..\..\Contact\contact3.txt");
                remplir();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.Create(fichierContacts).Close();
            remplir();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvContact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (checkBox1.Checked)
            {
                (this.Owner as Form1).Controls["cbxDestCa"].Text = dgvContact.CurrentCell.Value.ToString();
            }


            else
            {
                (this.Owner as Form1).Controls["cbxDest"].Text = dgvContact.CurrentCell.Value.ToString();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Destinataire caché";
            }


            else
            {
                checkBox1.Text = "Destinataire";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("L'adresse mail sur laquelle vous cliquez avec votre curseur sera exporté dans Destinataire (ou Destinataire Caché)");
        }
    }
}
