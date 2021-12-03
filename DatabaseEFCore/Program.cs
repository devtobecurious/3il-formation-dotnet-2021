// See https://aka.ms/new-console-template for more information
using DatabaseEFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder();
builder.AddJsonFile("appsettings.json");
var conf = builder.Build();

// Indiquer que c'est une base SQL SERVER
var optionBuilder = new DbContextOptionsBuilder();
optionBuilder.UseSqlServer(conf.GetConnectionString("MyGameSettings"));

// Ouverture de l'orm => instance
using var context = new GameContext(optionBuilder.Options);

// Pas de requête à la base de données
// prépare la requête
var query = from joueur in context.Joueurs
            select joueur;

// Requête SQL auto générée qui va être envoyée à la base de données
// Au retour : création de la liste des Joueurs
// suivant ma requête LINQ
var result = query.ToList(); // ou First, ou Any, ou FirstOrDefault()

foreach (var item in result)
{

}

