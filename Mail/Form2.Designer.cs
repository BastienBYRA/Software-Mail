namespace Mail
{
    partial class Form2
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
            this.dgvContact = new System.Windows.Forms.DataGridView();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.tbxMail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPrenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContact
            // 
            this.dgvContact.AllowUserToAddRows = false;
            this.dgvContact.AllowUserToDeleteRows = false;
            this.dgvContact.AllowUserToOrderColumns = true;
            this.dgvContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContact.Location = new System.Drawing.Point(357, 12);
            this.dgvContact.Name = "dgvContact";
            this.dgvContact.Size = new System.Drawing.Size(487, 240);
            this.dgvContact.TabIndex = 0;
            this.dgvContact.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContact_CellContentClick);
            // 
            // tbxID
            // 
            this.tbxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbxID.Location = new System.Drawing.Point(855, 46);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(252, 26);
            this.tbxID.TabIndex = 1;
            // 
            // tbxMail
            // 
            this.tbxMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbxMail.Location = new System.Drawing.Point(94, 148);
            this.tbxMail.Name = "tbxMail";
            this.tbxMail.Size = new System.Drawing.Size(252, 26);
            this.tbxMail.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(151, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ID.Location = new System.Drawing.Point(1113, 46);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(31, 25);
            this.ID.TabIndex = 4;
            this.ID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(30, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mail";
            // 
            // tbxNom
            // 
            this.tbxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbxNom.Location = new System.Drawing.Point(94, 45);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(252, 26);
            this.tbxNom.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(30, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nom";
            // 
            // tbxPrenom
            // 
            this.tbxPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbxPrenom.Location = new System.Drawing.Point(94, 94);
            this.tbxPrenom.Name = "tbxPrenom";
            this.tbxPrenom.Size = new System.Drawing.Size(252, 26);
            this.tbxPrenom.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prenom";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(924, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 39);
            this.button2.TabIndex = 10;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.Location = new System.Drawing.Point(890, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 39);
            this.button3.TabIndex = 11;
            this.button3.Text = "Supprimer tout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button4.Location = new System.Drawing.Point(568, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 33);
            this.button4.TabIndex = 12;
            this.button4.Text = "Quitter";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(868, 235);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Destinataire";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button5.Location = new System.Drawing.Point(868, 258);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 21);
            this.button5.TabIndex = 14;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1150, 301);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxPrenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxMail);
            this.Controls.Add(this.tbxID);
            this.Controls.Add(this.dgvContact);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContact;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.TextBox tbxMail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPrenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button5;
    }
}