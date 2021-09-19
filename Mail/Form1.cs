using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Mail
{
    public partial class Form1 : Form
    {
        public string serveur;
        public string port;



        string fichierServ = @"..\..\Contact\serveur.txt";
        string fichierPort = @"..\..\Contact\port.txt";
        string fichierContacts = @"..\..\Contact\contact.txt";



        List<Attachment> pièces_jointes;

        public Form1()
        {
            InitializeComponent();
            pièces_jointes = new List<Attachment>();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxObjet = new System.Windows.Forms.TextBox();
            this.tbxMsg = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tbxMailExp = new System.Windows.Forms.TextBox();
            this.tbxMDP = new System.Windows.Forms.TextBox();
            this.btnAjout = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.vraipiece = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnDest = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cbxSMTP = new System.Windows.Forms.ComboBox();
            this.cbxPort = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cbxDest = new System.Windows.Forms.ComboBox();
            this.cbxDestCa = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(27, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Serveur SMTP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(29, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Destinataire";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(29, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Dest. Caché";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(27, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Expediteur";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(29, 267);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Objet";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(29, 302);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Pieces jointes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(322, -213);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 285);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(635, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 20);
            this.label13.TabIndex = 7;
            this.label13.Text = "Message";
            // 
            // tbxObjet
            // 
            this.tbxObjet.Location = new System.Drawing.Point(167, 269);
            this.tbxObjet.Name = "tbxObjet";
            this.tbxObjet.Size = new System.Drawing.Size(178, 20);
            this.tbxObjet.TabIndex = 12;
            // 
            // tbxMsg
            // 
            this.tbxMsg.Location = new System.Drawing.Point(582, 101);
            this.tbxMsg.Multiline = true;
            this.tbxMsg.Name = "tbxMsg";
            this.tbxMsg.Size = new System.Drawing.Size(183, 283);
            this.tbxMsg.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "Envoyer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnContact
            // 
            this.btnContact.Location = new System.Drawing.Point(451, 351);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(100, 33);
            this.btnContact.TabIndex = 16;
            this.btnContact.Text = "Contact";
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(167, 351);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 33);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(316, 351);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 33);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Quitter";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button4_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label14.Location = new System.Drawing.Point(24, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(235, 29);
            this.label14.TabIndex = 19;
            this.label14.Text = "Mail de haute qualité";
            // 
            // tbxMailExp
            // 
            this.tbxMailExp.Location = new System.Drawing.Point(167, 129);
            this.tbxMailExp.Name = "tbxMailExp";
            this.tbxMailExp.Size = new System.Drawing.Size(178, 20);
            this.tbxMailExp.TabIndex = 21;
            // 
            // tbxMDP
            // 
            this.tbxMDP.Location = new System.Drawing.Point(365, 127);
            this.tbxMDP.Name = "tbxMDP";
            this.tbxMDP.PasswordChar = '*';
            this.tbxMDP.Size = new System.Drawing.Size(100, 20);
            this.tbxMDP.TabIndex = 22;
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(293, 302);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(52, 31);
            this.btnAjout.TabIndex = 23;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // vraipiece
            // 
            this.vraipiece.FormattingEnabled = true;
            this.vraipiece.Location = new System.Drawing.Point(167, 302);
            this.vraipiece.Name = "vraipiece";
            this.vraipiece.Size = new System.Drawing.Size(120, 43);
            this.vraipiece.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.Location = new System.Drawing.Point(471, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 20);
            this.label15.TabIndex = 26;
            this.label15.Text = "Port";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label16.Location = new System.Drawing.Point(471, 127);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 20);
            this.label16.TabIndex = 27;
            this.label16.Text = "Mot de passe";
            // 
            // btnDest
            // 
            this.btnDest.Location = new System.Drawing.Point(475, 190);
            this.btnDest.Name = "btnDest";
            this.btnDest.Size = new System.Drawing.Size(40, 60);
            this.btnDest.TabIndex = 28;
            this.btnDest.Text = "?";
            this.btnDest.UseVisualStyleBackColor = true;
            this.btnDest.Click += new System.EventHandler(this.btnDest_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label17.Location = new System.Drawing.Point(144, 40);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(172, 36);
            this.label17.TabIndex = 29;
            this.label17.Text = "Corporation";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label18.Location = new System.Drawing.Point(27, 153);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(122, 20);
            this.label18.TabIndex = 30;
            this.label18.Text = "Nom Expediteur";
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(167, 155);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(178, 20);
            this.tbxNom.TabIndex = 31;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(363, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 60);
            this.button2.TabIndex = 38;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbxSMTP
            // 
            this.cbxSMTP.FormattingEnabled = true;
            this.cbxSMTP.Location = new System.Drawing.Point(167, 92);
            this.cbxSMTP.Name = "cbxSMTP";
            this.cbxSMTP.Size = new System.Drawing.Size(178, 21);
            this.cbxSMTP.TabIndex = 39;
            // 
            // cbxPort
            // 
            this.cbxPort.FormattingEnabled = true;
            this.cbxPort.Location = new System.Drawing.Point(365, 92);
            this.cbxPort.Name = "cbxPort";
            this.cbxPort.Size = new System.Drawing.Size(100, 21);
            this.cbxPort.TabIndex = 40;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(515, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 21);
            this.button3.TabIndex = 41;
            this.button3.Text = "Ajouter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbxDest
            // 
            this.cbxDest.FormattingEnabled = true;
            this.cbxDest.Location = new System.Drawing.Point(167, 190);
            this.cbxDest.Name = "cbxDest";
            this.cbxDest.Size = new System.Drawing.Size(178, 21);
            this.cbxDest.TabIndex = 42;
            this.cbxDest.SelectedIndexChanged += new System.EventHandler(this.cbxDest_SelectedIndexChanged);
            // 
            // cbxDestCa
            // 
            this.cbxDestCa.FormattingEnabled = true;
            this.cbxDestCa.Location = new System.Drawing.Point(167, 229);
            this.cbxDestCa.Name = "cbxDestCa";
            this.cbxDestCa.Size = new System.Drawing.Size(178, 21);
            this.cbxDestCa.TabIndex = 43;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(354, 302);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 31);
            this.button4.TabIndex = 44;
            this.button4.Text = "Supprimer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(475, 302);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 33);
            this.button5.TabIndex = 45;
            this.button5.Text = "Actualiser";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 397);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cbxDestCa);
            this.Controls.Add(this.cbxDest);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cbxPort);
            this.Controls.Add(this.cbxSMTP);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnDest);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.vraipiece);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.tbxMDP);
            this.Controls.Add(this.tbxMailExp);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnContact);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxMsg);
            this.Controls.Add(this.tbxObjet);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            string file = openFileDialog1.FileName;
            if (cbxDest.Text != "")
            {
                MailMessage mail = new MailMessage(tbxMailExp.Text, cbxDest.Text, tbxObjet.Text, tbxMsg.Text);
            }

            if (cbxDestCa.Text != "")
            {
                MailMessage mail = new MailMessage(tbxMailExp.Text, cbxDestCa.Text, tbxObjet.Text, tbxMsg.Text);
            }


            SmtpClient clientSmtp = new SmtpClient(cbxSMTP.Text);
            MailMessage monMessage = new MailMessage();
            try
            {
                clientSmtp.Port = int.Parse(cbxPort.Text);
            }
            catch
            {
                //MessageBox.Show("Port invalide, veuillez en saisir un.");
            }

            try
            {
                clientSmtp.Host = cbxSMTP.Text;
            }
            catch
            {
                MessageBox.Show("Serveur invalide, veuillez en saisir un.");
            }
            clientSmtp.EnableSsl = true;
            clientSmtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            clientSmtp.UseDefaultCredentials = true;
            clientSmtp.Credentials = new NetworkCredential(tbxMailExp.Text, tbxMDP.Text);


            monMessage.Body = Convert.ToString(tbxMsg.Text);
            monMessage.Subject = Convert.ToString(tbxObjet.Text);

                //if (tbxDest.Text != "")
                //{
                //    MailAddress destinataire = new MailAddress(tbxDest.Text);
                //    monMessage.CC.Add(destinataire);
                //}

                //if (tbxDestCa.Text != "")
                //{
                //    MailAddress destinatairesBCC = new MailAddress(tbxDestCa.Text);
                //    monMessage.Bcc.Add(destinatairesBCC);
                //}



            if (cbxDest.Text == "" && cbxDestCa.Text == "")
            {
                MessageBox.Show("Destinataire invalide, veuillez en saisir un.");
                //Application.Restart();
            }

            try
            {
                MailAddress expediteur = new MailAddress(Convert.ToString(tbxMailExp.Text), Convert.ToString(tbxNom.Text));
                monMessage.From = expediteur;

                if (cbxDest.Text != "")
                {
                    monMessage = new MailMessage(tbxMailExp.Text, cbxDest.Text, tbxObjet.Text, tbxMsg.Text);
                    monMessage.IsBodyHtml = false;
                }
                else
                {
                    monMessage = new MailMessage(tbxMailExp.Text, cbxDestCa.Text, tbxObjet.Text, tbxMsg.Text);
                    monMessage.IsBodyHtml = false;
                }
            }
            catch
            {
                MessageBox.Show("Il manque, ou l'une des informations suivantes est invalide ; Expéditeur, Destinataire (caché), l'Objet.");
            }

            try
            {
                foreach (Attachment attach in pièces_jointes)
                {
                    monMessage.Attachments.Add(attach);
                }
            }
            catch
            {
                MessageBox.Show("La pièce jointe est invalide.");
            }


            if (tbxObjet.Text == "" && tbxMsg.Text == "" && vraipiece.Items == null)
            {
                MessageBox.Show("Votre courrier ne contient aucun Objet, Message et pièce jointe, il vous est recommandé d'en saisir un des trois (sous risque que votre mail atterrissent dans les spams du/des destinataires");
            }


            if (cbxDest.Text != "")
            {
                foreach (var address in cbxDest.Text.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries))
                {
                    monMessage.To.Add(address);
                }
            }


            if (cbxDestCa.Text != "")
            {
                foreach (var address in cbxDestCa.Text.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries))
                {
                    monMessage.Bcc.Add(address);
                }
            }





                 try
                 {
                   clientSmtp.Send(monMessage);
                   MessageBox.Show("Le message a été envoyé");
                  }
                 catch (Exception ex)
                 {
                    MessageBox.Show("Echec : " + ex.Message);
                 }
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                pièces_jointes.Add(new Attachment(openFileDialog1.FileName, MediaTypeNames.Application.Octet));
                vraipiece.Items.Add(openFileDialog1.SafeFileName);
            }

        }

        private void btnDest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pour entrer plus d'une adresse mail, vous devez mettre une adresse mail suivit du symbole < , >.                                                                               Voici un exemple ; MAIL1@gmail.com, MAIL2@gmail.com...");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cbxSMTP.Text = "";
            tbxMailExp.Text = "";
            cbxDest.Text = "";
            cbxDestCa.Text = "";
            tbxObjet.Text = "";
            tbxMDP.Text = "";
            cbxPort.Text = "";
            tbxNom.Text = "";
            tbxMsg.Text = "";
            vraipiece.Items.Clear();
        }

        //private void btnValeur_Click(object sender, EventArgs e)
        //{
        //    int i = 0;
        //    string[] contact = { tbxID.Text, tbxMail.Text };
        //    for (i = 0; i < 1; i++)
        //    {
        //        dgvContact.Rows.Add();
        //        if (dgvContact.Rows.Count == 0)
        //        {
        //            dgvContact.Rows.Add();
        //            dgvContact.Rows.Insert(0, contact);

        //        }
        //    }

        //}


        private void btnContact_Click(object sender, EventArgs e)
        {
            Form2 monForm2 = new Form2();
            monForm2.Owner = this;
            monForm2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 monForm3 = new Form3();
            monForm3.Owner = this;
            monForm3.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string ligne = null;
            //string line = null;
            //string ligne2 = null;
            //StreamReader contactsStreamReader = new StreamReader(fichierServ);
            //StreamReader contactsStreamReaderZ = new StreamReader(fichierPort);
            //StreamReader contactsStreamReaderZz = new StreamReader(fichierContacts);

            //while (!contactsStreamReader.EndOfStream)
            //{
            //    ligne = contactsStreamReader.ReadLine();
            //    string[] serv = ligne.Split(';');
            //    cbxSMTP.Items.Add(serv[1]);
            //}

            //while (!contactsStreamReaderZ.EndOfStream)
            //{
            //    line = contactsStreamReaderZ.ReadLine();
            //    string[] port = line.Split(';');
            //    cbxPort.Items.Add(port[1]);
            //}

            //while (!contactsStreamReaderZz.EndOfStream)
            //{
            //    ligne2 = contactsStreamReaderZz.ReadLine();
            //    string[] cont = ligne2.Split(';');
            //    cbxDest.Items.Add(cont[3]);
            //    cbxDestCa.Items.Add(cont[3]);
            //}
            //contactsStreamReader.Dispose();
            //contactsStreamReaderZ.Dispose();
            //contactsStreamReaderZz.Dispose();
           

            cbxDest.Items.Clear();
            cbxDestCa.Items.Clear();
            cbxSMTP.Items.Clear();
            cbxPort.Items.Clear();

            combo_chargement();
            //cbxDest.Items.Refresh();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            Form4 monForm4 = new Form4();
            monForm4.Owner = this;
            monForm4.ShowDialog();
        }

        public void combo_chargement()
        {
            string ligne = null;
            string line = null;
            string ligne2 = null;
            StreamReader contactsStreamReader = new StreamReader(fichierServ);
            StreamReader contactsStreamReaderZ = new StreamReader(fichierPort);
            StreamReader contactsStreamReaderZz = new StreamReader(fichierContacts);

            while (!contactsStreamReader.EndOfStream)
            {
                ligne = contactsStreamReader.ReadLine();
                string[] serv = ligne.Split(';');
                cbxSMTP.Items.Add(serv[1]);
            }

            while (!contactsStreamReaderZ.EndOfStream)
            {
                line = contactsStreamReaderZ.ReadLine();
                string[] port = line.Split(';');
                cbxPort.Items.Add(port[1]);
            }

            while (!contactsStreamReaderZz.EndOfStream)
            {
                ligne2 = contactsStreamReaderZz.ReadLine();
                string[] cont = ligne2.Split(';');
                cbxDest.Items.Add(cont[3]);
                cbxDestCa.Items.Add(cont[3]);
            }

            contactsStreamReader.Dispose();
            contactsStreamReaderZ.Dispose();
            contactsStreamReaderZz.Dispose();

            contactsStreamReader.Close();
            contactsStreamReaderZ.Close();
            contactsStreamReaderZz.Close();



        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            vraipiece.Items.Clear();
        }

        private void cbxDest_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //this.Refresh();
            //Refresh();
            //this.Hide();
            //Form1 ss = new Form1();
            //ss.Show();

            //this.Refresh();
            //Application.DoEvents();

            Form1_Load(null, EventArgs.Empty);
        }
    }
}
