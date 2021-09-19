using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mail
{
    public partial class Form4 : Form
    {

        string fichierServ = @"..\..\Contact\serveur.txt";
        string fichierPort = @"..\..\Contact\port.txt";


        public Form4()
        {
            InitializeComponent();

            int nbCols = 2;
            dgvServ.ColumnCount = nbCols;

            dgvServ.ColumnHeadersVisible = true;
            dgvServ.Columns[0].HeaderText = "ID";
            dgvServ.Columns[1].HeaderText = "Serveur";



            dgvPort.ColumnCount = nbCols;

            dgvPort.ColumnHeadersVisible = true;
            dgvPort.Columns[0].HeaderText = "ID";
            dgvPort.Columns[1].HeaderText = "Port";

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            actualiserServ();
            actualiserPort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbxServ.Text != "")
            {
                var lineCount = File.ReadLines(fichierServ).Count();

                string ligne;
                StreamWriter contactSW;

                if (!File.Exists(fichierServ))
                {
                    contactSW = new StreamWriter(fichierServ);
                }
                else
                {
                    contactSW = File.AppendText(fichierServ);
                }

                ligne = lineCount + 1 + ";" + tbxServ.Text;

                contactSW.WriteLine(ligne);

                contactSW.Close();
                contactSW.Dispose();
                actualiserServ();
            }
            else
            {
                MessageBox.Show("Veuillez entrez un serveur.");
            }
        }

        public void actualiserServ()
        {
            if (File.Exists(fichierServ))
            {
                dgvServ.RowCount = 1;
                dgvServ.ColumnCount = 2;
                int i = 0;
                string[] Serveur = File.ReadAllLines(fichierServ);

                foreach (string unServeur in Serveur)
                {
                    dgvServ.Rows.Add();
                    string[] port = unServeur.Split(';');
                    for (int j = 0; j < 2; j++)
                    {
                        dgvServ[j, i].Value = port[j];
                    }
                    i++;
                }
            }
        }


        public void actualiserPort()
        {
            if (File.Exists(fichierPort))
            {
                dgvPort.RowCount = 1;
                dgvPort.ColumnCount = 2;
                int i = 0;
                string[] Port = File.ReadAllLines(fichierPort);

                foreach (string unPort in Port)
                {
                    dgvPort.Rows.Add();
                    string[] port = unPort.Split(';');
                    for (int j = 0; j < 2; j++)
                    {
                        dgvPort[j, i].Value = port[j];
                    }
                    i++;
                }
            }
        }



        private void dgvPort_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            (this.Owner as Form1).Controls["cbxPort"].Text = dgvPort.CurrentCell.Value.ToString();
        }

        private void btnPort_Click(object sender, EventArgs e)
        {
            if (tbxPort.Text != "")
            {
                var lineC = File.ReadLines(fichierPort).Count();


                string line;
                StreamWriter portSW;

                if (!File.Exists(fichierPort))
                {
                    portSW = new StreamWriter(fichierPort);
                }
                else
                {
                    portSW = File.AppendText(fichierPort);
                }

                line = lineC + 1 + ";" + tbxPort.Text;

                portSW.WriteLine(line);

                portSW.Close();
                portSW.Dispose();
                actualiserPort();
            }
            else
            {
                MessageBox.Show("Veuillez entrez un port.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            File.Create(fichierServ).Close();
            actualiserServ();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            File.Create(fichierPort).Close();
            actualiserPort();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                String fichierServ2 = @"..\..\Contact\serveur2.txt";
                String ligne;
                Boolean trouve = false;
                StreamReader contactSR = new StreamReader(fichierServ);
                StreamWriter contactSW = new StreamWriter(fichierServ2);

                while (!contactSR.EndOfStream)
                {
                    ligne = contactSR.ReadLine();
                    String[] tabLigne = ligne.Split(';');
                    if (tabLigne[0] != tbxIDS.Text)
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


                File.Replace(fichierServ2, fichierServ, @"..\..\Contact\serveur3.txt");
                actualiserServ();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String fichierPort2 = @"..\..\Contact\port2.txt";
            String ligne;
            Boolean trouve = false;
            StreamReader contactSR = new StreamReader(fichierPort);
            StreamWriter contactSW = new StreamWriter(fichierPort2);

            while (!contactSR.EndOfStream)
            {
                ligne = contactSR.ReadLine();
                String[] tabLigne = ligne.Split(';');
                if (tabLigne[0] != tbxIDP.Text)
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
            actualiserPort();


            File.Replace(fichierPort2, fichierPort, @"..\..\Contact\port3.txt");
        }

        private void dgvServ_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            (this.Owner as Form1).Controls["cbxSMTP"].Text = dgvServ.CurrentCell.Value.ToString();
        }
    }
}
