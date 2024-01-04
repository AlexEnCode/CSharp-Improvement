using ConsoleApp1;


Chaise chaise = new Chaise();
Chaise lepere = new Chaise(10, "marbre", "blanc", 500, false);
Chaise sdlgiu = new Chaise(4, "bois", "bois", 500, false);
Chaise fleuf = new Chaise(3, "fer", "gris", 500, false);
Chaise sdlkgj = new Chaise(1, "plastoc", "noir", 500, true);
Chaise perklo = new Chaise(4, "poo", "blanc", 500, true);

List<Chaise> mesChaises = new List<Chaise>()
{
    chaise,
    lepere,
    sdlgiu,
    fleuf,
    sdlkgj,
    perklo,
    };

foreach (Chaise a in mesChaises)
{
    a.AfficherlesInfos();
}

Console.WriteLine(perklo.ToString());