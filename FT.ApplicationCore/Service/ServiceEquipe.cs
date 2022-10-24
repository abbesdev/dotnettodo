using System;
using System.Linq;
using System.Numerics;
using FT.ApplicationCore.Domain;
using FT.ApplicationCore.Interface;

namespace FT.ApplicationCore.Service
{
    public class ServiceEquipe : IServiceEquipe
    {
        public List<Equipe> Equipes { get; set; } = new List<Equipe>();
        public List<Membre> Membres { get; set; } = new List<Membre>();

        public void GetEquipeMembers(Equipe equipe)
        {
            var req = (from m in Membres
                       where m.equipes == equipe
                       select new { m.Nom,  m.Prenom }).ToList();
            foreach (var mm in req)
            {
                Console.WriteLine(mm);
            }
        }

        public List<Trophee> GetEquipeTrophees(string equipeId)
        {
            throw new NotImplementedException();
        }

        public void ShowEquipeDetails(Equipe equipe)
        {
            throw new NotImplementedException();
        }
    }
}

