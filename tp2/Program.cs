// See https://aka.ms/new-console-template for more information

using tp2;

Projet projet = new Projet(
        1,
        "software dev",
        5,
        5
    );
    
projet.add(new Programmeur(1, "bougueddach", "mohamed", 3));
projet.add(new Programmeur(2, "bougueddach", "oussama", 3));
projet.add(new Programmeur(3, "bougueddach", "anas", 2));
projet.add(new Programmeur(4, "bougueddach", "omar", 2));
projet.add(new Programmeur(5, "bougueddach", "fz", 1));

projet.afficherProgrammeur(2);
Console.WriteLine("\n========================= All prog =======================\n");
projet.afficherAllProgrammeurs();
Console.WriteLine("\n========================= change bureau =======================\n");
projet.changerBureauProgrammeur(4, 1);
projet.afficherProgrammeur(1);
// Console.WriteLine("\n========================= All prog =======================\n");
projet.AjouterConsommation(3, 1);
projet.AjouterConsommation(3, 1);
projet.AjouterConsommation(5, 2);
projet.AjouterConsommation(5, 4);
projet.AjouterConsommation(2, 3);
projet.AjouterConsommation(2, 2);
projet.AjouterConsommation(1, 5);
projet.AjouterConsommation(3, 3);
Console.WriteLine("\n========================= All prog =======================\n");
Console.WriteLine(projet.calculNbTasseConsome(1));


