//string[] heroes = { "Harry Potter", "Luke Skywalker", "Lara Croft", "Scooby Doo" };
//string[] villains = { "Voldemort", "Beetlejuice", "Dracula", "Batman" };

string folderPath = @"C:\\Users\\anvor\\Downloads\\data\";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath,villainFile));

string[] weapon = { "banana", "spatula", "plasticspoon", "rubber chicken" };



string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today the glorious {hero}, with the help of the mighty {heroWeapon} saves the day!");

string villain = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today the notorious {villain} tries to take over the world with the force of the deadly {villainWeapon} !");


static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    String randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}
