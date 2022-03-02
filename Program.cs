using LastWar.SRC.Entities;


System.Console.WriteLine("Abstraindo um jogo de RPG");

Mage Newnell = new Mage("Newnell", 1, "Mage", "damn impact", 1, 50, 100, 10, 100, 100);
System.Console.WriteLine(Newnell.description());
System.Console.WriteLine(Newnell.attack());

// Knight Rutti = new Knight("Rutti", 1, "Knight", "faint", 100, 50, 1, 100, 100, 100);
// System.Console.WriteLine(Rutti.description());
// System.Console.WriteLine(Rutti.attack());

// Rogue Bandit = new Rogue("Bandit", 1, "Rogue", "accurate shot", 10, 50, 50, 10, 100, 100);
// Sorcerer Paul = new Sorcerer("Paul", 1, "Sorcerer", "death freeze", 1, 50, 100, 10, 100, 100);
// Titan Chatra = new Titan("Chatra", 1, "Titan", "earthquake", 100, 10, 1, 100, 100, 100);
// Healer Athena = new Healer("Athena", 1, "Mage", "arrow of silence", 1, 100, 50, 1, 100, 100);