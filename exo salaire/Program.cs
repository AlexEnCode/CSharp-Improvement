using exo_salaire;



Salarie salaire1 = new Salarie(Guid.NewGuid(), "RH", "salarié", "Prunelle", 30000);
Salarie salaire2 = new Salarie(Guid.NewGuid(), "finance", "salarié", "Nicolas", 45000);
Salarie salaire3 = new Salarie(Guid.NewGuid(), "admin", "salarié", "Nauroto", 50000);
Salarie salaire4 = new Salarie(Guid.NewGuid(), "admin", "chef", "Pablo", 100000);
Salarie salaire5 = new Salarie(Guid.NewGuid(), "admin", "sous-chef", "Fernand", 100000);


List<Salarie> mesSalarie = new List<Salarie>()
{
    salaire1,
    salaire2,
    salaire3,
    salaire4,
    salaire5,
    };

foreach (Salarie salarie in mesSalarie)
{
    salarie.AfficherSalaire();
}

Console.WriteLine();
Console.WriteLine("Le salaire de base est de "+ Salarie.salaireBase + " euros.");
Console.WriteLine("Il y a " + Salarie.NombreSalarie + " salarié dans l'entreprise.");
Console.WriteLine("le montant total des salaires des employés est de " + Salarie.SommeSalaire +" euros.");
Console.WriteLine("Le salaire moyen de l'entreprise est de " + Salarie.MoyenneSalaire + " euros.");


Console.Write("Quelle est le nouveau salaire de Prunelle ? ");
string? h = Console.ReadLine();
int sPrunelle;
int.TryParse(h, out sPrunelle);

salaire1.Salaire = sPrunelle;

Console.WriteLine("Le nouveau salaire de Prunelle est de : "+ salaire1.Salaire + " euros.");

Console.WriteLine("le nouveau montant total des salaires des employés est de " + Salarie.SommeSalaire + " euros.");
Console.WriteLine("Le nouveau salaire moyen de l'entreprise est de " + Salarie.MoyenneSalaire + " euros.");