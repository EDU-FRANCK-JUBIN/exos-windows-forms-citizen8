using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databinding
{
    class Personne
    {
        private string m_nom;
        private string m_prenom;
        private DateTime m_dateNaissance;
        private int m_age;

        public Personne(string nom, string prenom, DateTime dateNaissance, int age)
        {
            m_nom = nom;
            m_prenom = prenom;
            m_dateNaissance = dateNaissance;
            m_age = age;
        }

        public Personne()
        {

        }

        public Personne(string nom)
        {
            m_nom = nom;
        }

        public Personne(string nom, string prenom, DateTime dateNaissance)
        {
            m_nom = nom;
            m_prenom = prenom;
            m_dateNaissance = dateNaissance;
        }

        public string Nom { get => m_nom; set => m_nom = value; }
        public string Prenom { get => m_prenom; set => m_prenom = value; }
        public DateTime DateNaissance { get => m_dateNaissance; set => m_dateNaissance = value; }
        public int Age { get => m_age; set => m_age = value; }


    }
}
