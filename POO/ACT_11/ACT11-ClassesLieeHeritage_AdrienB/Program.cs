namespace ACT11_ClassesLieeHeritage_AdrienB
{
    using ACT11_ClassesLieeHeritage_AdrienB.Classes;
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {

            Salle salleMaths = new Salle("Salle 101", 30);
            Salle sallePhysique = new Salle("Salle 202", 25);


            Cours coursMaths = new Cours("Mathématiques", salleMaths, new List<double> { 15, 18, 12 });
            Cours coursPhysique = new Cours("Physique", sallePhysique, new List<double> { 14, 17, 13 });


            List<InfoCours> listeCoursEnseignant = new List<InfoCours>
        {
            new InfoCours(coursMaths, 16),
            new InfoCours(coursPhysique, 12)
        };

            Enseignant enseignant1 = new Enseignant("Durand", "Paul", "paul.durand@gmal.com", "0678451236", new DateTime(2015, 9, 1), "Sciences", listeCoursEnseignant);


            List<InfoCours> listeCoursEtudiant1 = new List<InfoCours>
        {
            new InfoCours(coursMaths, 16),
            new InfoCours(coursPhysique, 14)
        };

            List<InfoCours> listeCoursEtudiant2 = new List<InfoCours>
        {
            new InfoCours(coursMaths, 12),
            new InfoCours(coursPhysique, 15)
        };

            Etudiant etudiant1 = new Etudiant("Dupont", "Alice", "alice.dupont@gmail.com", "0654321987", 2022, listeCoursEtudiant1);
            Etudiant etudiant2 = new Etudiant("Martin", "Lucas", "lucas.martin@hotmail.com", "0651234879", 2021, listeCoursEtudiant2);


            Departement departementSciences = new Departement("Sciences", "Physique & Mathématiques", new List<Enseignant> { enseignant1 });
            Ecole ecole1 = new Ecole("ECOLE123", "www.mon-ecole.com", new List<Salle> { salleMaths, sallePhysique }, new List<Departement> { departementSciences });


            Academie academie1 = new Academie("Académie de Namur", new List<Ecole> { ecole1 });


            Console.WriteLine($"Académie : {academie1.Nom}");
            foreach (var ecole in academie1.ListeEcoles)
            {
                Console.WriteLine($"École : {ecole.CodeEcole} - {ecole.SiteInternet}");
                foreach (var dep in ecole.ListeDepartements)
                {
                    Console.WriteLine($"Département : {dep.Nom} ({dep.Matiere})");
                    dep.AfficherEnseignants();
                }
            }

            Console.WriteLine("\nListe des étudiants :");
            Console.WriteLine($"  - {etudiant1.Nom} {etudiant1.Prenom}, année d'entrée : {etudiant1.AnneeEntree}");
            Console.WriteLine($"  - {etudiant2.Nom} {etudiant2.Prenom}, année d'entrée : {etudiant2.AnneeEntree}");
        }
    }
}
