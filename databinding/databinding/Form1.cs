using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databinding
{
    public partial class Form1 : Form
    {
        List<Personne> lesPersonnes = new List<Personne>();

        

        public Form1()
        {
            InitializeComponent();


            Personne unePersonne = new Personne();
            lesPersonnes.Add(unePersonne);
            lesPersonnes.Add(new Personne("LeBienNomé"));
            lesPersonnes.Add(new Personne("sor", "jean", Convert.ToDateTime("01/01/2012")));
            personneBindingSource.DataSource = lesPersonnes;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
