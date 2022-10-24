using System;
using System.Numerics;
using FT.ApplicationCore.Domain;

namespace FT.ApplicationCore.Interface
{
    public interface IServiceEquipe
    {
        List<Trophee> GetEquipeTrophees(String equipeId);
        void ShowEquipeDetails(Equipe equipe);
        void GetEquipeMembers(Equipe equipe);


    }
}

