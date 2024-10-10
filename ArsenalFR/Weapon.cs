
using System.Text.Json.Serialization;
public class Weapon
{
    [JsonInclude]
    public string name;
    [JsonInclude]
    public int damageMin;
    [JsonInclude]
    public int damageMax;
    
    public int attack()
    {
        return Random.Shared.Next(damageMin, damageMax);
    }
}