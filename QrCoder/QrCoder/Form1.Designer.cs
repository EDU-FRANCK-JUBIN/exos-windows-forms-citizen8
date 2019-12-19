namespace QrCoder
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbNomPDF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.lbText = new System.Windows.Forms.Label();
            this.lbTextEncoder = new System.Windows.Forms.Label();
            this.tbTextEncode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(959, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "QRCode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(952, 603);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "PDF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbNomPDF
            // 
            this.tbNomPDF.Location = new System.Drawing.Point(959, 399);
            this.tbNomPDF.Name = "tbNomPDF";
            this.tbNomPDF.Size = new System.Drawing.Size(194, 29);
            this.tbNomPDF.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(959, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom du pdf";
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(959, 497);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(336, 83);
            this.tbText.TabIndex = 4;
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Location = new System.Drawing.Point(959, 453);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(122, 25);
            this.lbText.TabIndex = 5;
            this.lbText.Text = "Text du PDF";
            // 
            // lbTextEncoder
            // 
            this.lbTextEncoder.AutoSize = true;
            this.lbTextEncoder.Location = new System.Drawing.Point(954, 107);
            this.lbTextEncoder.Name = "lbTextEncoder";
            this.lbTextEncoder.Size = new System.Drawing.Size(148, 25);
            this.lbTextEncoder.TabIndex = 6;
            this.lbTextEncoder.Text = "Texte a encodé";
            // 
            // tbTextEncode
            // 
            this.tbTextEncode.Location = new System.Drawing.Point(959, 155);
            this.tbTextEncode.Name = "tbTextEncode";
            this.tbTextEncode.Size = new System.Drawing.Size(336, 29);
            this.tbTextEncode.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 930);
            this.Controls.Add(this.tbTextEncode);
            this.Controls.Add(this.lbTextEncoder);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNomPDF);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbNomPDF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Label lbTextEncoder;
        private System.Windows.Forms.TextBox tbTextEncode;
    }
}

