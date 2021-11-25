using FonctionsRefOut; // namespace = espace de noms

var calculateur = new Calculateur();

var result = -1;

calculateur.Add(1, 2, ref result);

Console.WriteLine(result);

result = calculateur.Add(2, 3);
result = calculateur.Add(2, 3, 4);
result = calculateur.Add(2, 3, 4, 6);


result = calculateur.Add(2, 3, 4, 6, 1, 2, 3, 4, 5, 6, 8);



result = calculateur.Add(2, "3");

decimal ttc = calculateur.ToTTC(10);
ttc = calculateur.ToTTC(10, 1.1925M);



