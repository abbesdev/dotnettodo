using System;
namespace FT.ApplicationCore.Domain
{
    public class Equipe
    {
        public String AddresseLocal {get ; set; }
        public int EquipeId { get; set; }
        public String Logo { get; set; }
        public String NomEquipe { get; set; }
        List<Trophee> Trophees { get; set; }
        ICollection<Membre> Membres { get; set; }

        public Equipe(String addresseLocal, int equipeId, String logo, String nomEquipe, ICollection<Membre> members)
        {
            AddresseLocal = addresseLocal;
            EquipeId = equipeId;
            Logo = logo;
            NomEquipe = nomEquipe;
            Membres = members;

        }
        public Equipe(String addresseLocal, int equipeId, String logo, String nomEquipe)
        {
            AddresseLocal = addresseLocal;
            EquipeId = equipeId;
            Logo = logo;
            NomEquipe = nomEquipe;
            

        }
        public override string ToString()
        {
            return "Nom equipe : "+NomEquipe + " Addresse Local : "+AddresseLocal;
        }
    }
}

