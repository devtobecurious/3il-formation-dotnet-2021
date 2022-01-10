using Drone.Library;
using Drone.Library.DataLayers;
using Drone.Library.Interfaces;
using Drone.Library.Repositories;
using DroneTracking;

// DeliveryMachina machina = new DeliveryMachina("12135d4ff");

IDroneDataLayer datalayer = new DroneDataLayer();
// IDroneDataLayer datalayer = new FakeDroneDataLayer();
DroneRepository repository = new(datalayer);


int resultalt3 = 0;
try
{
    resultalt3 = int.Parse(Console.ReadLine()) / 0;
    var list = repository.GetUsingAll();

    foreach (var item in list)
    {
        string registre = item.RegistrationNumber;
        Console.WriteLine($"Mon drone {registre}");
    }
}
catch(NotImplementedException ex)
{
    Console.WriteLine("Oops Erreur " + ex.Message);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Oops tu sais pas compter ;)");
}
finally
{
    Console.WriteLine("Fin du try catch");
    // c'est ici qu'on ferme les fichiers, les accès au bases de données
}

Console.WriteLine("Hello, c'est la fin de mon programme ! :D");







string resultat = Console.ReadLine();
if (resultat == "FIN")
{
    Console.WriteLine("C'est la fin");
}
else
{
    string message = "Pas la fin";
    Console.WriteLine(message);
}
// Console.WriteLine(message);

{
    string message2 = "Pas la fin";
    Console.WriteLine(message2);
}

// Console.WriteLine(message2);