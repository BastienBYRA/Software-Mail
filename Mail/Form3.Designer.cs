namespace Mail
{
    partial class Form3
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
            this.cbxServ = new System.Windows.Forms.ComboBox();
            this.cbxPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnValide = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxServ
            // 
            this.cbxServ.FormattingEnabled = true;
            this.cbxServ.Location = new System.Drawing.Point(39, 49);
            this.cbxServ.Name = "cbxServ";
            this.cbxServ.Size = new System.Drawing.Size(121, 21);
            this.cbxServ.TabIndex = 0;
            this.cbxServ.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbxPort
            // 
            this.cbxPort.FormattingEnabled = true;
            this.cbxPort.Location = new System.Drawing.Point(215, 49);
            this.cbxPort.Name = "cbxPort";
            this.cbxPort.Size = new System.Drawing.Size(121, 21);
            this.cbxPort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "DestinataireCC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(191, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "DestinataireCCI";
            // 
            // btnValide
            // 
            this.btnValide.Location = new System.Drawing.Point(73, 90);
            this.btnValide.Name = "btnValide";
            this.btnValide.Size = new System.Drawing.Size(233, 41);
            this.btnValide.TabIndex = 4;
            this.btnValide.Text = "Valider";
            this.btnValide.UseVisualStyleBackColor = true;
            this.btnValide.Click += new System.EventHandler(this.btnValide_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Quitter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(393, 225);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnValide);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPort);
            this.Controls.Add(this.cbxServ);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxServ;
        private System.Windows.Forms.ComboBox cbxPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnValide;
        private System.Windows.Forms.Button button1;
    }
}