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



{
    Salarie salarie = CreerSalarie();

    Console.WriteLine("Informations de l'employé généré :");
    Console.WriteLine($"Nom: {salarie.Nom}");
    Console.WriteLine($"Matricule: {salarie.Matricule}");
    Console.WriteLine($"Catégorie: {salarie.Categorie}");
    Console.WriteLine($"Service: {salarie.Service}");
    Console.WriteLine($"Salaire: {salarie.Salaire}");
}
 Salarie CreerSalarie() // request()
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



void creatObjectCommercial()
{

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
            Console.WriteLine("--- Salaire des employés ---\n ");
            foreach (object Salarie in Salarie){ 
                Console.WriteLine("Le salaire fixe de" + Salarie.Nom + " est de " + Salarie.Salaire + " euros.");}
            foreach (object Commercial in Commercial ){ 
                Console.WriteLine("Le salaire fixe de" + Commercial.Nom + " est de " + Commercial.Salaire + " euros.\t Le saaire avec commission est de " + Commercial.commission + " euros.");}

            break;

        case "3":
            Console.WriteLine("--- Recherche des employés ---\n ");
            Console.Write("Merci de saisir un nom");

            break;

        case "0":
            quitter = true; 
            break;

        default:
            Console.WriteLine("Erreur de saisie, recommencez !");
            break;
    }
}