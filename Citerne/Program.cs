using System.Collections.Generic;
using Citerne;

void marge()
{
    Console.WriteLine();
    Console.WriteLine("------------------------------------------------------------------------------------------------");
    Console.WriteLine();

}

 WaterTank Citerne1 = new WaterTank("Lassie Terne", 10, 20, 0);
 WaterTank Citerne2 = new WaterTank("Merci Terne", 15, 30, 0);
 WaterTank Citerne3 = new WaterTank("Felicie Terne", 30, 60, 0);

List<WaterTank> mesCiterne = new List<WaterTank>()
{
    Citerne1,
    Citerne2,
    Citerne3,
    };


marge();

foreach (WaterTank WaterTank in mesCiterne)
{
    WaterTank.AfficherCiterne();
}

marge();


for (int i = 0; i < mesCiterne.Count; i++)
    Console.WriteLine("\tLe poid total de " + mesCiterne[i].Name + " est de " + mesCiterne[i].Poids + " Tonne.");

marge();

for (int i = 0; i < mesCiterne.Count; i++)
    Console.WriteLine("\tLa quantité d'eau de " + mesCiterne[i].Name + " est de " + mesCiterne[i].Niveau + "  Tonne d'eau.");

marge();


    Console.Write("Combien d'eau rajoutes tu dans les citernes ? ");
    string? h = Console.ReadLine();
int flotte;
int.TryParse(h, out flotte);


double exces;

for (int i = 0; i < mesCiterne.Count; i++) { 
    if (flotte <= mesCiterne[i].Capacite)
    { 
    mesCiterne[i].Niveau =  flotte;
    exces = 0;
}
else
    {
        mesCiterne[i].Niveau = mesCiterne[i].Capacite;
        exces =  flotte - mesCiterne[i].Capacite;
             
    }
    Console.WriteLine("\tAprès ajouts, il y a " + mesCiterne[i].Niveau + " Tonne d'eau dans la citerne, et " + exces + " Tonne d'eau en d'excès.");
}
marge();




Console.Write("Combien d'eau retire tu dans les citernes ? ");
string? j = Console.ReadLine();
int deflotte;
int.TryParse(j, out deflotte);


for (int i = 0; i < mesCiterne.Count; i++)
{
    if (flotte <= mesCiterne[i].Capacite)
    {
        mesCiterne[i].Niveau = flotte - deflotte;
        exces = 0;
    }
    else
    {
        mesCiterne[i].Niveau = mesCiterne[i].Capacite;
        exces = deflotte - mesCiterne[i].Capacite;

    }
    if (exces <= 0)
        exces = 0;

    Console.WriteLine("\tAprès ajouts, il y a " + mesCiterne[i].Niveau + " Tonne d'eau dans la citerne, et " + exces + " Tonne d'eau en d'excès.");
}


marge();

for (int i = 0; i < mesCiterne.Count; i++)
    mesCiterne[i].AffichageCiterne();

