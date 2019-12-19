using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QrCoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textEncode = tbTextEncode.Text;

            if (textEncode.Length == 0)
            {
                MessageBox.Show("Le champ est vide",
                                "Erreur",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                //quite la fonction
                return;
            }

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCoderData = qrGenerator.CreateQrCode(textEncode, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCoderData);
            Bitmap qrCodeImg = qrCode.GetGraphic(20);

            PictureBox picture = new PictureBox();
            picture.Width = 500;
            picture.Height = 500;
            picture.Image = qrCodeImg;
            this.Controls.Add(picture);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cheminDocument = Directory.GetCurrentDirectory() + @"/";

            string nomFichierPDF = tbNomPDF.Text;

            //si le nom du PDF est vide
            if(nomFichierPDF.Length == 0)
            {
                MessageBox.Show("Le nom du fichier est vide",
                                "Erreur",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                //quite la fonction
                return;
            }

            string chemin = cheminDocument + nomFichierPDF + ".pdf";

            string text = tbText.Text;

            if (File.Exists(chemin))
            {
                MessageBox.Show("Le fichier existe déjà, entré un nom différent",
                                "Erreur",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                //quite la fonction
                return;
            }

            //création du PDF
            PdfWriter pdfWriter = new PdfWriter(chemin);
            PdfDocument pdfDocument = new PdfDocument(pdfWriter);
            Document document = new Document(pdfDocument);

            document.Add(new Paragraph(text));
            document.Close();

            //ouverture du document
            if (File.Exists(chemin))
                System.Diagnostics.Process.Start(chemin);
            else
                MessageBox.Show("Le fichier n'existe pas !",
                                    "Erreur",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

            //supprime le text dans les textBox
            tbNomPDF.Text = "";
            tbText.Text = "";

        }
    }
}
