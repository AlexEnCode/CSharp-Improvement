using System.Collections.Generic;
using Compte_bancaire;


Client monClient = new( nom, prenom, identifiant, listeDesComptes));

monClient = 



Console.WriteLine("=== Menu Principale ===");
Console.WriteLine();
Console.WriteLine("1.  Lister les comptes bancaires");
Console.WriteLine("2.  Creer un compte banquaire");
Console.WriteLine("3.  Effectuer un dépot");
Console.WriteLine("4.  Effectuer un retrait");
Console.WriteLine("5.  Afficher les operations et le solde");
Console.WriteLine("0.  Quitter le programme");


Console.WriteLine();
Console.Write("entrez votre choix :");
string choice;
choice = Console.ReadLine();
Console.Clear();

switch (choice)
{
    case "1":
     
        break;
    case "2":
        Console.WriteLine("=== Creation de Compte ===");
        Console.WriteLine("1.  creer un compte courant");
        Console.WriteLine("2.  creer un compte epargne");
        Console.WriteLine("3.  creer un compte payant");
        Console.WriteLine("0.  Annuler la création d'un compte");

        Console.WriteLine();
        Console.Write("entrez votre choix :");
        string choice1;
        choice1 = Console.ReadLine();
        Console.Clear();

        switch (choice)
        {
            case "1":
                
                break;
            case "2":
               
                break;
            case "3":
               
                break;
            default:
                Console.WriteLine("Tu t'es gourré");
                break;
        }
        break;
    case "3":
        
break;
    case "4":

        break;
    case "5":

        break;
    default:   
        Console.WriteLine("Tu t'es gourré");
        break;
}