using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;

namespace Mail
{
    public partial class Form3 : Form
    {
        //Form3 form3;


        public string serveur;
        public string port;
        string fichierContacts = @"..\..\Contact\contact.txt";

        public Form3()
        {
            InitializeComponent();

            //cbxServ.Items.Add("");
            //cbxServ.Items.Add("smtp.free.fr");
            //cbxServ.Items.Add("smtp.gmail.com");
            //cbxServ.Items.Add("smtp.live.com");
            //cbxServ.Items.Add("smtp.orange.fr");
            //cbxServ.Items.Add("smtp.sfr.fr");
            //cbxServ.Items.Add("smtp.wanadoo.fr");
            //cbxServ.Items.Add("mail.yahoo.com");

            //cbxPort.Items.Add("");
            //cbxPort.Items.Add("25");
            //cbxPort.Items.Add("80");
            //cbxPort.Items.Add("465");
            //cbxPort.Items.Add("587");
            //cbxPort.Items.Add("2525");

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //(this.Owner as Form1).Controls["cbxSMTP"].Text += cbxServ.SelectedItem.ToString();

            //(this.Owner as Form1).Controls["cbxPort"].Text += cbxPort.SelectedItem.ToString();
            //this.Close();







            //string ligne = null;
            //StreamReader contactsStreamReader = new StreamReader(fichierContacts);

            //while (!contactsStreamReader.EndOfStream)
            //{
            //    ligne = contactsStreamReader.ReadLine();
            //    string[] contact = ligne.Split(';');
            //    cbxPort.Items.Add(contact[3]);
            //}


        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string ligne = null;
            StreamReader contactsStreamReader = new StreamReader(fichierContacts);

            while (!contactsStreamReader.EndOfStream)
            {
                ligne = contactsStreamReader.ReadLine();
                string[] contact = ligne.Split(';');
                cbxPort.Items.Add(contact[3]);
                cbxServ.Items.Add(contact[3]);
            }

            contactsStreamReader.Dispose();
            contactsStreamReader.Close();
        }

        private void btnValide_Click(object sender, EventArgs e)
        {
            StreamReader contactSR = new StreamReader(fichierContacts);


            if (cbxServ.Text != "" && cbxPort.Text == "")
            {
                //(this.Owner as Form1).Controls["tbxDest"].Text = String.Empty;
                (this.Owner as Form1).Controls["cbxDest"].Text += cbxServ.SelectedItem.ToString() + ", ";
            }

            if (cbxPort.Text != "" && cbxServ.Text == "")
            {
                (this.Owner as Form1).Controls["cbxDestCa"].Text += cbxPort.SelectedItem.ToString() + ", ";
            }

            if (cbxServ.Text != "" && cbxPort.Text != "")
            {

                (this.Owner as Form1).Controls["cbxDest"].Text += cbxServ.SelectedItem.ToString() + ", ";
                (this.Owner as Form1).Controls["cbxDestCa"].Text += cbxPort.SelectedItem.ToString() + ", ";
            }
            contactSR.Dispose();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
