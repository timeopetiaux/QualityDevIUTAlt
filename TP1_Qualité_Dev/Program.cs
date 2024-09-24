// See https://aka.ms/new-console-template for more information

using System;
using System.Runtime.InteropServices;

namespace TP1_Qualité_Dev {

    class Program
    {

        public class Media
        {
            private String titre;
            private int numReference;
            private int nbExemplaireDisponible;
            public virtual void AfficherInfos()
            {
                Console.WriteLine($"Titre: {Titre}, Numéro de référence: {NumReference}, Nombre d'exemplaires disponibles: {NbExemplaireDisponible}");
            }
        }

        public class DVD : Media
        {
            private String Duree;
            public override void AfficherInfos()
            {
                base.AfficherInfos();
                Console.WriteLine($"Durée du DVD : {Duree}");
            }
        }

        public class CD : Media
        {
            private String Artiste;
            public override void AfficherInfos()
            {
                base.AfficherInfos();
                Console.WriteLine($"Artiste du CD : {Artiste}");
            }

        }

        public class Livre : Media
        {
            private String Auteur;
            public override void AfficherInfos()
            {
                base.AfficherInfos();
                Console.WriteLine($"Auteur du Livre : {Auteur}");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}


