using System;
using System.Collections.Generic;
using Tp_2; 

class Program
{
    static void Main()
    {
        // --- Exercice 1 ---
        Livre livre1 = new Livre("Les Misérables", 2.5);
        Video video1 = new Video("Maitre Gims", 0.025);
        Disque disque1 = new Disque("Cheb Mami", 1.5);
        int duree = 5;

        double cout1 = livre1.CalculateRent(duree);
        double cout2 = video1.CalculateRent(duree);
        double cout3 = disque1.CalculateRent(duree);

        Console.WriteLine($"Vous allez payer : {cout1} € pour {duree} jours de location du livre {livre1.nom}");
        Console.WriteLine($"Vous allez payer : {cout2} € pour {duree} jours de location de la vidéo {video1.nom}");
        Console.WriteLine($"Vous allez payer : {cout3} € pour {duree} jours de location du disque {disque1.nom}");

        Console.WriteLine("\n--- Exercice Classes Abstraites ---");

        // --- Exercice 2  ---
        List<Publication> publications = new List<Publication>()
        {
            new BookPub("Harry Potter", 15.5),
            new Videopub("Inception", 12.0),
            new Disopub("Thriller - MJ", 10.0)
        };

        foreach (var pub in publications)
        {
            pub.Publierdetail();
        }
    }
}
