using System.ComponentModel.DataAnnotations.Schema;
using Salaire2;

string question(string qst)
{
    Console.Write(qst);
    return Console.ReadLine();
}
double questionDouble(string qst)
{
    Console.Write(qst);
    string? h = Console.ReadLine();
    double i;
    double.TryParse(h, out i);
    return i;
}

void request()
{
   string nom = question("Merci de saisir le nom :");
   string matricule = question("Merci de saisir le matricule :");
   string categorie = question("Merci de saisir la catégorie :");
   string service = question("Merci de saisir le service :");
   double Salaire = questionDouble("Merci de saisir le salaire :");
}

void requestComm()
{
    double ca = questionDouble("Merci de saisir le chiffre d'affaire :");
    double commission = questionDouble("Merci de saisir la commission :");
}


void menuing()
{
    Console.WriteLine("--- Ajouter des employés ---\n ");
    Console.Write("1----Salarié" +
    "\n2----Commerciale" +
    "\n0----Retour" +
    "\n\nFaites votre choix : ");
}

bool quitter = false;

while (!quitter)
{
    string choice;
    Console.WriteLine("--- Gestion des employés ---\n ");
    Console.Write("1----Ajouter un employé" +
        "\n2----Afficher le salaire des employés" +
        "\n3----Rechercher un employé" +
        "\n0----Quitter" +
        "\n\nFaites votre choix : ");
    choice = Console.ReadLine();
    Console.Clear();


    switch (choice)
    {
        case "1":
            menuing();
            string Choise1 = Console.ReadLine();
                   
            switch (Choise1)
            {
                case "1":
                    request();
                    break;
                
                case "2":
                    request();
                    requestComm();
                    break;
                    default: Console.WriteLine("Erreur de saisie, recommencez !");
                    break;
            }
            break;

        case "2":
           
        case "3":
            
        case "4":

        case "0":
            quitter = true; // return ou env exit
            break;
        default:
            Console.WriteLine("Erreur de saisie, recommencez !");
            break;
    }
}