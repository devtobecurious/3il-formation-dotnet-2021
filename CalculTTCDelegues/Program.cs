using static CalculTTCDelegues.Delegates;

double monNombre = 12.2D;
// monNombre = "eeee";

double res = RetourneTvaCMR();
GetTva maFonction = RetourneTvaCMR;
res = maFonction();

// SetTva maProc = RetourneTvaCMR; // pourquoi ça ne marche pas ici ?
SetTva maProc2 = Test;



void Test(double tva)
{

}






double ht = DemandeEtRecupereMontantHT();


double ttc = CalculTTC(ht, RetourneTvaFR);
ttc = CalculTTC(ht, RetourneTvaCMR);
//ttc = CalculTTC(ht, RetourneFausseTva);

double CalculTTC(double montantHT, GetTva getTva)
{
    return montantHT * getTva();
}


double DemandeEtRecupereMontantHT()
{
    Console.WriteLine("Le montant HT s'il vous plaît");
    string montantSaisie = Console.ReadLine();
    return double.Parse(montantSaisie);
}

double RetourneTvaFR()
{
    return 1.2D;
}

double RetourneTvaCMR()
{
    return 1.195D;
}

int RetourneFausseTva()
{
    return 2;
}

