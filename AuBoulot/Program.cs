
using AuBoulot;

Chef boss = new Chef();
Chef chief = new Chef() 
{ 
    NPlusUn = boss 
};

DevelopPerson tom = new DevelopPerson()
{
    Responsable = chief,
    Prenom = "Tom"
};

DevelopPerson claudine = new DevelopPerson()
{
    Responsable = chief,
    Prenom = "Claudine"
};

DevelopPerson christelle = new DevelopPerson()
{
    Responsable = chief,
    Prenom = "Christelle"
};

chief.Team.Add(tom);
chief.Team.Add(christelle);
chief.Team.Add(claudine);


tom.TravailFini += TravailFini;
tom.TravailFini += PrevenirBoss;

tom.TravailFini += christelle.FaireAutreTache;
tom.TravailFini += claudine.FaireAutreTache;

chief.DonnerTravail(tom);


void TravailFini()
{
    Console.WriteLine("Le travail est fini");
}

void PrevenirBoss()
{
    Console.WriteLine("je previens le boss");
}

