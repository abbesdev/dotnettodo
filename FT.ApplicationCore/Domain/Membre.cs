using System;

namespace FT.ApplicationCore.Domain
{
    public class Membre
    {
      public DateTime DateNaissance { get; set; }
      public int Identifiant { get; set; }
      public String Nom { get; set; }
      public String Prenom { get; set; }
        public Equipe equipes { get; set; }

        public Membre()
        {

        }
        public Membre(DateTime dateNaissance, int identifiant, String nom, String prenom, Equipe equipe)
        {
            DateNaissance = dateNaissance;
            Identifiant = identifiant;
            Nom = nom;
            Prenom = prenom;
            equipes = equipe;
        }

        public override string ToString()
        {
            return "Date de naissance : " + DateNaissance + " Identifiant : " + Identifiant+ " Nom :"+Nom+ " Prenom : "+Prenom;
        }

       
    }
}

