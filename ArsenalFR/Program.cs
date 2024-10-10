using System.Text.Json;

int numberOfAttacks = 0;
string attackString = "";
int dmgTotal = 0;

string textWeapon = File.ReadAllText("weapons.json");

Weapon scythe  = JsonSerializer.Deserialize<Weapon>(textWeapon);

Console.WriteLine("# of attacks");


while (!int.TryParse(attackString, out numberOfAttacks))
{
  attackString = Console.ReadLine();
}


for (int i = 0; i < numberOfAttacks; i++)
{
  int damage = scythe.attack();
  Console.WriteLine($"{damage}");
  dmgTotal += damage;
}

Console.WriteLine($"Scythe dealt a total of {dmgTotal} damage");





Console.ReadLine();


// Weapon scythe = new Weapon()
// {
//     Name = "Grimm's Scythe",
//     damageMin = 10,
//     damageMax = 50
// };

// string jsonWeapon = JsonSerializer.Serialize<Weapon>(scythe); 
// File.WriteAllText("weapon.json", jsonWeapon