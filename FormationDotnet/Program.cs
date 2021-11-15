// See https://aka.ms/new-console-template for more information
using FormationDotnet;


string[] choices = new string[3] 
{ 
    "nouvelle partie", 
    "charger une nouvelle partie", 
    "quitter le jeu" 
};
// for (int i = 0; i < choices.Length; i++)
// {
//     Console.WriteLine(choices[i]);
// }

//List<string> choicesList = new List<string>();
//choicesList.Add("nouvelle partie");
//choicesList.Add("charger une nouvelle partie");
//choicesList.Add("quitter le jeu");

//for (int i = 0; i < choicesList.Count; i++)
//{
//    Console.WriteLine(choicesList[i]);
//}
//foreach (var item in choicesList)
//{
//    Console.WriteLine(item);
//}


//var choices2 = new string[3];


string title = "Harry Potter - Save the castle !";
var titleEx = "Harry Potter - Save the castle !";

// titleEx = 2;

Console.WriteLine(title.ToUpper());
//Console.WriteLine("===============================");
for (int i = 0; i < title.Length; i++)
{
    Console.Write("=");
}
Console.WriteLine();


bool ageValid = false;
while (!ageValid)
{
    Console.WriteLine("Quel est votre date de naissance ?");
    var resultBirthday = "";
    resultBirthday = Console.ReadLine();

    DateTime tryBirthDay = DateTime.MinValue;
    if (DateTime.TryParse(resultBirthday, out tryBirthDay))
    {
        DateTime today = DateTime.Now;
        var result = today - tryBirthDay;

        int age = (int)result.TotalDays / 365;

        Console.WriteLine($"Votre âge est bien { age }.");

        ageValid = age > 13;
    }
}

// TODO: La notion de culture
// DateTime birthday = DateTime.Parse(resultBirthday);




// Console.WriteLine(String.Format("Votre âge est bien {0}.", resultAge));

// QUID pour vérifier l'âge ?!

bool isDone = false;
//MenuChoiceType type = MenuChoiceType.NewGame;

while (! isDone)
{
    Console.WriteLine("menu du jeu".ToUpper());
    //Console.WriteLine($"{(int) MenuChoiceType.NewGame}. {choices[0]}".ToUpper());
    //Console.WriteLine($"{(int) MenuChoiceType.LoadGame}. {choices[1]}".ToUpper());
    //Console.WriteLine($"{(int) MenuChoiceType.Exit}. {choices[2]}".ToUpper());

    var choiceValues = Enum.GetValues(typeof(MenuChoiceType));

    // BUG: ça n'affiche pas le bon index de l'enum
    for (int i = 0; i < choices.Length; i++)
    {
        Console.WriteLine($"{(int) choiceValues.GetValue(i)} - {choices[i]}".ToUpper());
    }

    Console.WriteLine("Votre choix ?");
    var resultChoice = Console.ReadLine();
    //if (resultChoice == "0")
    //{
    //    isDone = true;
    //}

    int exitValue = (int)MenuChoiceType.Exit;
    string exitValueString = exitValue.ToString();

    isDone = resultChoice == exitValueString;

    if (resultChoice == ((int) MenuChoiceType.NewGame).ToString()) 
    {
        // Démarrage du jeu
        DateTime startGame = DateTime.Now;
        Console.WriteLine($"Le jeu a commencé le : {startGame.Year}/{startGame.Month} à {startGame.Hour} // {startGame.ToString("dddd ddd dd MMMM yy")}");
    }
}



