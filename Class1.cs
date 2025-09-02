using System;


namespace Tp_2
{
    public interface IRentable
    {
        public double CalculateRent(int duree);
        
    }
    public class Livre :IRentable
    {
        public double prix;
        public string nom;
        public Livre(string nom , double prix)
        {
            this.nom = nom; 
            this.prix = prix;  // prix par jour 
        }
        public double CalculateRent(int duree)// durée par jour 
        {
            return prix * duree;
        }
    }
    public class Disque : IRentable
    {
        public double prix;
        public string nom;
        public Disque(string nom, double prix)
        {
            this.nom = nom;
            this.prix = prix;  // prix par jour 
        }
        public double CalculateRent(int duree)// durée par jour 
        {
            return prix * duree;
        }
    }
    public class Video: IRentable
    {
        public double prix;
        public string nom;
        public Video(string nom, double prix)
        {
            this.nom = nom;
            this.prix = prix;  // prix par jour 
        }
        public double CalculateRent(int duree)// durée par jour 
        {
            return prix * duree;
        }
    }
    public abstract class Publication
    {
        public string Name { get; set;}
        public double Price { get; set; }
        public Publication (string name, double price)
        {
            Name = name;
            Price = price;
        

        }
        public abstract void Publierdetail();

    }
    public class BookPub : Publication
    {
        public BookPub(string name, double price) : base(name, price )
        {
        }
        public override void Publierdetail()
        {
            Console.WriteLine($" Livre : {Name}, Prix : {Price} €");
        }
    }
    public class Videopub : Publication
    {
        public Videopub(string name, double price ) : base(name, price) { }
        public override void Publierdetail()
        {
            Console.WriteLine($" Video : {Name}, Prix : {Price} €");
        }
    }
    public class Disopub : Publication
    {
        public Disopub(string name, double price) : base(name, price) { }
        public override void Publierdetail()
        {
            Console.WriteLine($" Disque : {Name}, Prix : {Price} €");
        }
    }
    public delegate double DiscountStrategy(Publication article);
    public static class DiscountMethods
    {
        
        public static double RemiseFixe(Publication article)
        {
            return article.Price * 0.9;
        }

        
        public static double RemiseLivre(Publication article)
        {
            if (article is BookPub)
                return article.Price * 0.8;
            return article.Price; 
        }

       
        public static double PasDeRemise(Publication article)
        {
            return article.Price;
        }
    }


}

