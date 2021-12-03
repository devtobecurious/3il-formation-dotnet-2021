
using FinalGame.Lib;

List<Character> list = new List<Character>()
{
    new Player() { Surname = "Harry Potter", LifePoint = 100 },
    new Player() { Surname = "Hermione", LifePoint = 50 },
    new Player() { Surname = "Ron", LifePoint = 10 }
};


// prépa de la requete
var query = from perso in list
            where perso.Surname == "Ron" &&
                  perso.LifePoint > 50
            orderby perso.Surname, perso.LifePoint
            select perso;

// exécution de la requete
var result = query.ToList();
var premierElement = query.FirstOrDefault();

try
{
    var premierElementBis = query.First();
}
catch (Exception exT)
{
    Console.WriteLine("Il y a eu une exception " + exT.Message);
}
finally
{
    Console.WriteLine("S'exécute toujours, meme si pas de catch. dans tous les cas");
}


// le parcours des resultats de la requete
foreach (var item in result)
{

}
