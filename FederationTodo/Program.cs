// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Collections.Generic;
using FT.ApplicationCore.Domain;
using FT.ApplicationCore.Service;

Console.WriteLine("Hello, World!");
ServiceEquipe se = new ServiceEquipe();
Equipe e = new Equipe("Rue barcelone, Spain", 876, "", "FC Barecelona");

Membre m = new Membre(new DateTime(2022, 01, 28, 21, 10, 10),765,"Abbes","Mohamed",equipe:e);
Membre m1 = new Membre(new DateTime(2022, 01, 28, 21, 10, 10), 765, "Gouiaa", "Ahmed",e);
Membre m2 = new Membre(new DateTime(2022, 01, 28, 21, 10, 10), 765, "Mejdoub", "Taha",e);
ICollection<Membre> membersList = new List<Membre>();
membersList.Add(m);
membersList.Add(m1);
membersList.Add(m2);

Console.WriteLine("test");
se.GetEquipeMembers(e);






