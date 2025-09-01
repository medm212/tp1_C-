// See https://aka.ms/new-console-template for more information

using System;

namespace tp1_exo1
{
    class Article
    {
        protected string designation;
        protected int prix;

        public Article(string des, int prix) // constructeur public correct
        {
            designation = des;
            this.prix = prix;
        }

        public void Acheter()
        {
            Console.WriteLine($"Vous achetez : {designation} pour {prix}€");
        }
    }

    class Livre : Article
    {
        protected int isbn;
        protected int nbpage;

        public Livre(int isbn, int nbpage, string des, int prix) : base(des, prix)
        {
            this.isbn = isbn;
            this.nbpage = nbpage;
        }
    }

    class Poche : Livre
    {
        private string categorie;

        public Poche(string categorie, int isbn, int nbpage, string des, int prix)
            : base(isbn, nbpage, des, prix)
        {
            this.categorie = categorie;
        }
    }

    class Broche : Livre
    {
        public Broche(int isbn, int nbpage, string des, int prix)
            : base(isbn, nbpage, des, prix)
        {
        }
    }

    class Disque : Article
    {
        protected string label;

        public Disque(string label, string des, int prix) : base(des, prix)
        {
            this.label = label;
        }

        public void Ecouter()
        {
            Console.WriteLine($"Écoute du disque : {designation} ({label})");
        }
    }

    class Video : Article
    {
        protected int duree;

        public Video(int duree, string des, int prix) : base(des, prix)
        {
            this.duree = duree;
        }

        public void Afficher()
        {
            Console.WriteLine($"Vidéo : {designation}, Durée : {duree} min, Prix : {prix}€");
        }
    }
    class Program
    {
        static void Main()
        {
            Article a1 = new Article("Stylo", 2);
            a1.Acheter();
            Livre l1 = new Livre(123456, 300, "Le C#", 25);
            l1.Acheter();
            Poche p1 = new Poche("Roman", 654321, 200, "Harry Potter", 10);
            p1.Acheter();

            Broche b1 = new Broche(789012, 400, "Programmation .NET", 30);
            b1.Acheter();

            Disque d1 = new Disque("Sony Music", "Best of 2025", 15);
            d1.Acheter();
            d1.Ecouter();

            Video v1 = new Video(120, "Film d'action", 20);
            v1.Acheter();
            v1.Afficher();

        }
    }
}



namespace tp1_exo2
{
    struct Article
    {
        public string nom;
        public double prix;
        public int quantite;

        // Constructeur
        public Article(string nom, double prix, int quantite)
        {
            this.nom = nom;
            this.prix = prix;
            this.quantite = quantite;
        }

        // Méthode Afficher
        public void Affich()
        {
            Console.WriteLine($"Article : {nom}, Prix : {prix}€, Quantité : {quantite}");
        }

        // Méthode Retirer
        public void Retirer(int q)
        {
            if (q > 0 && q <= quantite)
                quantite -= q;
            else
                Console.WriteLine("Quantité à retirer invalide.");
        }

        // Méthode Ajouter
        public void Ajouter(int q)
        {
            if (q > 0)
                quantite += q;
            else
                Console.WriteLine("Quantité à ajouter invalide.");
        }
    }


}



namespace tp1_exo3
{
    enum TypeArticle
    {
        Alimentaire,
        Droguerie,
        Habillement,
        Loisir
    }

    struct ArticleType
    {
        public string Nom;
        public double Prix;
        public int Quantite;
        public TypeArticle Type; 
        public ArticleType(string nom, double prix, int quantite, TypeArticle type)
        {
            Nom = nom;
            Prix = prix;
            Quantite = quantite;
            Type = type;
        }

        
        public void Afficher()
        {
            Console.WriteLine($"Article : {Nom}, Prix : {Prix}€, Quantité : {Quantite}, Type : {Type}");
        }

        public void Ajouter(int q)
        {
            if (q > 0)
                Quantite += q;
        }

        public void Retirer(int q)
        {
            if (q > 0 && q <= Quantite)
                Quantite -= q;
        }
    }
}