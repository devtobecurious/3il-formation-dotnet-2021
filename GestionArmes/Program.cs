using LesArmes;

AfficherArmes();

List<Arme> RetournerList()
{
    List<Arme> armes = new List<Arme>();

    armes.Add(new Baguette() {  Libelle = "Peau de dragon", Puissance = 100, Matiere = "Dragon" });
    armes.Add(new Croc() { Libelle = "Croc blanc", Puissance = 50 });
    armes.Add(new Fusil() { Libelle = "Magique", Puissance = 150 });

    return armes;
}


void AfficherArmes()
{
    List<Arme> armes = RetournerList();

    foreach (var item in armes)
    {
        Console.WriteLine(item);
    }
}
