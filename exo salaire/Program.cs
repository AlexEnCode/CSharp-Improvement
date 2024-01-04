using exo_salaire;



Salarie salaire1 = new Salarie(System.Guid.NewGuid(), "RH", "salarié", "Prunelle", 30000);
Salarie salaire2 = new Salarie(System.Guid.NewGuid(), "finance", "salarié", "Nicolas", 45000);
Salarie salaire3 = new Salarie(System.Guid.NewGuid(), "admin", "salarié", "Nauroto", 50000);
Salarie salaire4 = new Salarie(System.Guid.NewGuid(), "admin", "chef", "Pablo", 100000);
Salarie salaire5 = new Salarie(System.Guid.NewGuid(), "admin", "sous-chef", "Fernand", 100000);


List<Salarie> mesChaises = new List<Salarie>()
{
    
    salaire1,
    salaire2,
    salaire3,
    salaire4,
    salaire5,
    };

foreach (Salarie salarie in mesChaises)
{
    salarie.AfficherSalaire();
}

Console.WriteLine("Il y a " + Salarie.NombreSalarie + " salarié dans l'entreprise.");