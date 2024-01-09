using System.ComponentModel.DataAnnotations.Schema;
using Salaire2;

string question(string qst)
{
    Console.Write(qst);
    return Console.ReadLine();
}
decimal questionDouble(string qst)
{
    Console.Write(qst);
    string? h = Console.ReadLine();
    decimal i;
    decimal.TryParse(h, out i);
    return i;
}


List<Salarie> listeSalaries = new(20);
Salarie CreerSalarie()  
{
   string nom = question("Merci de saisir le nom :");
   string matricule = question("Merci de saisir le matricule :");
   string categorie = question("Merci de saisir la catégorie :");
   string service = question("Merci de saisir le service :");
    decimal Salaire = questionDouble("Merci de saisir le salaire :");

    
    return new Salarie(nom, matricule, categorie, service, Salaire);
}

List<Commercial> listeCommerciaux = new(20);
Commercial CreerCommercial()  
{
    string nom = question("Merci de saisir le nom :");
    string matricule = question("Merci de saisir le matricule :");
    string categorie = question("Merci de saisir la catégorie :");
    string service = question("Merci de saisir le service :");
    decimal Salaire = questionDouble("Merci de saisir le salaire :");
    decimal ca = questionDouble("Merci de saisir le chiffre d'affaire :");
    decimal comission = questionDouble("Merci de saisir la comission :");

    return new Commercial(nom, matricule, categorie, service, Salaire, ca, comission);
}






/*
    Salarie salarie = CreerSalarie(),
{
    Console.WriteLine("Informations de l'employé généré :");
    Console.WriteLine($"Nom: {salarie.Nom}");
    Console.WriteLine($"Matricule: {salarie.Matricule}");
    Console.WriteLine($"Catégorie: {salarie.Categorie}");
    Console.WriteLine($"Service: {salarie.Service}");
    Console.WriteLine($"Salaire: {salarie.Salaire}");
}


    Commercial commercial = CreerCommercial()
{
    Console.WriteLine("Informations de l'employé généré :");
    Console.WriteLine($"Nom: {commercial.Nom}");
    Console.WriteLine($"Matricule: {commercial.Matricule}");
    Console.WriteLine($"Catégorie: {commercial.Categorie}");
    Console.WriteLine($"Service: {commercial.Service}");
    Console.WriteLine($"Salaire: {commercial.Salaire}");
    Console.WriteLine($"Chiffre d'Affaire: {commercial.Ca}");
    Console.WriteLine($"Commission: {commercial.Commission}");
}*/

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
                    CreerSalarie();
                    break;
                
                case "2":
                    CreerCommercial();
                    break;
                    default: Console.WriteLine("Erreur de saisie, recommencez !");
                    break;
            }
            break;

        case "2":
            Console.WriteLine("--- Salaire des employés ---\n ");
            foreach (Salarie Salarie in ListeSalarie){ 
                Console.WriteLine("Le salaire fixe de" + Salarie.Nom + " est de " + Salarie.Salaire + " euros.");}

            foreach (Commercial Commercial in ListeCommercial)
            { 
                Console.WriteLine("Le salaire fixe de" + Commercial.Nom + " est de " + Commercial.Salaire + " euros.\t Le saaire avec commission est de " + Commercial.Commission + " euros.");}

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