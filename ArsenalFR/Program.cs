using System.Text.Json;

int numberOfAttacks = 0;
string attackString = "";
int dmgTotal = 0;

string textWeapon = File.ReadAllText("weapons.json");
string textDummy = File.ReadAllText("dummy.json");


Weapon scythe  = JsonSerializer.Deserialize<Weapon>(textWeapon);
Enemy dummy = JsonSerializer.Deserialize<Enemy>(textDummy);

Console.WriteLine("What is the name of your Dummy?");

dummy.name = Console.ReadLine();

Console.WriteLine($"Your dummy is named {dummy.name}.");
Console.WriteLine("How many attacks do you wish to perform?");


while (!int.TryParse(attackString, out numberOfAttacks))
{
  attackString = Console.ReadLine();
}


for (int i = 0; i < numberOfAttacks; i++)
{
  int damage = scythe.attack();
  dummy.hitpoints -= damage;
  Console.WriteLine($"You dealt {damage} to {dummy.name}.");
  Console.WriteLine($"{dummy.name} now has {dummy.hitpoints} HP.");
  dmgTotal += damage;
}
 


Console.WriteLine($"Scythe dealt a total of {dmgTotal} damage to {dummy.name}");





Console.ReadLine();


// Weapon scythe = new Weapon()
// {
//     Name = "Grimm's Scythe",
//     damageMin = 10,
//     damageMax = 50
// };

// string jsonWeapon = JsonSerializer.Serialize<Weapon>(scythe); 
// File.WriteAllText("weapon.json", jsonWeapon


// Enemy dummy = new()
// {
//   name = "Dummy",
//   hitpoints = 100,
// };
// string jsonDummy = JsonSerializer.Serialize(dummy);
// File.WriteAllText("dummy.json", jsonDummy);

// Console.ReadLine();
