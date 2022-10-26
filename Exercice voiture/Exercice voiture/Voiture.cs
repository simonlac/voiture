using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_voiture
{
    class Voiture
    {

       public string matricule;
       public string marque;
       public string modele;
        int prix;
       public string couleurs;
        int poids;
        public static int nb_instances = 0;
        int Prix
        {
            get { return this.prix; }
            set { if (value >= 0) this.prix = value; }
        }
        int Poids
        {
            get { return this.poids; }
            set { if (value >= 0) this.poids = value; }
        }
        public static void Incrementer()
        {
            nb_instances++;
            Console.WriteLine("le nombre de véhicule instanciée est");
        }
        public void Afficher()
        {
            string s = "";
            s += "- matricule : " + matricule;
            s += "- marque : " + marque;
            s += "- modele : " + modele;
            s += "- prix : " + this.prix;
            s += "- matricule : " + couleurs;
            s += "- poids : " +this.poids;
            Console.WriteLine(s);
        }
    }
}
