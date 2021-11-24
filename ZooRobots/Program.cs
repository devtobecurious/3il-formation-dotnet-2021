// See https://aka.ms/new-console-template for more information
using ZooRobots;

//Lion mufasa = new Lion("Mufasa");
//Lion kovu = new("Kovu");
//var simba = new Lion("Simba");


//simba.NbPattes = 4;
//simba.CouleurCriniere = "Fauve";
//simba.DateArrivee = DateTime.Now.AddMonths(-1);
//simba.Prenom = "Simba";
//simba.Id = 1;

//simba.NbPattes = 3;

//mufasa.Prenom = "Mufasa";
//simba.DateArrivee = DateTime.Now.AddMonths(-12);

//DateTime newDate = new DateTime(2019, 1, 1);
//newDate = newDate.AddYears(-2);

//kovu.Prenom = "Kovu";


//bool aMange = simba.SeNourrir("herbe");
//mufasa.SeNourrir("viande");
//kovu.SeNourrir("viande");


//var aigle1 = new Aigle(1, "Thorondor");
//aigle1.Senvoler();
//aigle1.SeNourrir("viande");

//aigle1 = new Aigle(2, "Jack");

//List<Aigle> aigles = new List<Aigle>();
//aigles.Add(aigle1);
//aigles.Add(new Aigle(3, "Argil"));
//aigles.Add(new Aigle(1, "Thorondor"));

//foreach (var item in aigles)
//{
//    //Console.WriteLine($"{item.Id} => {item.Prenom}");
//    //item.Senvoler();

//    // Console.WriteLine(item.ToString());
//    Console.WriteLine(item);
//    item.Dormir();
//}


List<Animal> animals = new List<Animal>();

animals.Add(new Aigle(1, "Thorondor"));
animals.Add(new Lion("Simba"));


foreach (Animal item in animals)
{
    item.Dormir();
}




Console.WriteLine("Hello, World!");
