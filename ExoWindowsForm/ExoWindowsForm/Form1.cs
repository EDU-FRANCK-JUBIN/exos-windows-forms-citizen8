using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExoWindowsForm
{
    public partial class Form1 : Form
    {

        List<Bitmap> lsPictureList = new List<Bitmap>();

        public Form1()
        {
            InitializeComponent();
            lsPictureList.AddRange(new Bitmap[] { Properties.Resources._1, Properties.Resources._2, Properties.Resources._3, Properties.Resources._4, Properties.Resources._5,
                Properties.Resources._6, Properties.Resources._7, Properties.Resources._8, Properties.Resources._9, Properties.Resources._null });
        }

        private void rechargeImage()
        {
            var rand = new Random();
            int j;
            int nullSlice = 0;

            List<int> listNbImg = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 9 });



            for(int i = 0; i < 9; i++)
            {

                listNbImg.Remove((j = listNbImg[rand.Next(0, listNbImg.Count)]));
                ((PictureBox)groupBox1.Controls[i]).Image = lsPictureList[j];
                if (i == 9) nullSlice = i;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            rechargeImage();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb1_Click(object sender, EventArgs e)
        {

        }

        bool CheckWin()
        {
            int i;

            for (i = 0; i<8; i++)
            {
                if ((groupBox1.Controls[i] as PictureBox).Image != lsPictureList[i]) break;
            }
            if (i == 8) return true;
            else return false;
            
        }

        private void MovePicture(object sender, EventArgs e)
        {

        }
    }
}
