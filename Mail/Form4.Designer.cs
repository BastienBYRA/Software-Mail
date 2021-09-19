namespace Mail
{
    partial class Form4
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
            this.dgvServ = new System.Windows.Forms.DataGridView();
            this.tbxServ = new System.Windows.Forms.TextBox();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.dgvPort = new System.Windows.Forms.DataGridView();
            this.btnPort = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbxIDS = new System.Windows.Forms.TextBox();
            this.tbxIDP = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPort)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvServ
            // 
            this.dgvServ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServ.Location = new System.Drawing.Point(22, 59);
            this.dgvServ.Name = "dgvServ";
            this.dgvServ.Size = new System.Drawing.Size(306, 243);
            this.dgvServ.TabIndex = 0;
            this.dgvServ.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServ_CellContentClick);
            // 
            // tbxServ
            // 
            this.tbxServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbxServ.Location = new System.Drawing.Point(112, 15);
            this.tbxServ.Name = "tbxServ";
            this.tbxServ.Size = new System.Drawing.Size(216, 29);
            this.tbxServ.TabIndex = 1;
            // 
            // tbxPort
            // 
            this.tbxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbxPort.Location = new System.Drawing.Point(502, 15);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(216, 29);
            this.tbxPort.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Serveur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.Location = new System.Drawing.Point(444, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnEnregistrer.Location = new System.Drawing.Point(23, 319);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(216, 37);
            this.btnEnregistrer.TabIndex = 5;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvPort
            // 
            this.dgvPort.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPort.Location = new System.Drawing.Point(412, 59);
            this.dgvPort.Name = "dgvPort";
            this.dgvPort.Size = new System.Drawing.Size(306, 243);
            this.dgvPort.TabIndex = 6;
            this.dgvPort.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPort_CellContentClick);
            // 
            // btnPort
            // 
            this.btnPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnPort.Location = new System.Drawing.Point(412, 319);
            this.btnPort.Name = "btnPort";
            this.btnPort.Size = new System.Drawing.Size(216, 37);
            this.btnPort.TabIndex = 7;
            this.btnPort.Text = "Enregistrer";
            this.btnPort.UseVisualStyleBackColor = true;
            this.btnPort.Click += new System.EventHandler(this.btnPort_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(259, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Quitter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button2.Location = new System.Drawing.Point(773, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 37);
            this.button2.TabIndex = 9;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button3.Location = new System.Drawing.Point(773, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 37);
            this.button3.TabIndex = 10;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbxIDS
            // 
            this.tbxIDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbxIDS.Location = new System.Drawing.Point(773, 59);
            this.tbxIDS.Name = "tbxIDS";
            this.tbxIDS.Size = new System.Drawing.Size(216, 29);
            this.tbxIDS.TabIndex = 11;
            // 
            // tbxIDP
            // 
            this.tbxIDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbxIDP.Location = new System.Drawing.Point(773, 230);
            this.tbxIDP.Name = "tbxIDP";
            this.tbxIDP.Size = new System.Drawing.Size(216, 29);
            this.tbxIDP.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button4.Location = new System.Drawing.Point(876, 94);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 52);
            this.button4.TabIndex = 13;
            this.button4.Text = "Supprimer tout";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button5.Location = new System.Drawing.Point(876, 265);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 51);
            this.button5.TabIndex = 14;
            this.button5.Text = "Supprimer tout";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label3.Location = new System.Drawing.Point(873, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "ID Serveur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label4.Location = new System.Drawing.Point(909, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "ID Port";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1017, 379);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tbxIDP);
            this.Controls.Add(this.tbxIDS);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPort);
            this.Controls.Add(this.dgvPort);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxPort);
            this.Controls.Add(this.tbxServ);
            this.Controls.Add(this.dgvServ);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServ;
        private System.Windows.Forms.TextBox tbxServ;
        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.DataGridView dgvPort;
        private System.Windows.Forms.Button btnPort;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbxIDS;
        private System.Windows.Forms.TextBox tbxIDP;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}