using GameAndDie;

bool finPartie = false;

Character enemy = new Enemy()
{
    LifePoint = 100,
    Surname = "Voldemort"
};

Character player = new Player()
{
    LifePoint = 100,
    Surname = "Harry Potter"
};

player.IsDied += PlayerIsDied;

Random random = new Random();

Console.WriteLine("================================");
Console.WriteLine("========= PARTIE DEMARREE ======");
Console.WriteLine("================================");
while (! finPartie)
{
    int coup = random.Next(0, 20);
    player.Attaquer(coup, enemy);

    coup = random.Next(0, 20);
    enemy.Attaquer(coup, player);
}

void PlayerIsDied(Character player)
{
    finPartie = true;
}