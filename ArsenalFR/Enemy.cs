using System.Text.Json.Serialization;

public class Enemy
{
    [JsonInclude]
    public string name;
    [JsonInclude]
    public int hitpoints = 100;
}