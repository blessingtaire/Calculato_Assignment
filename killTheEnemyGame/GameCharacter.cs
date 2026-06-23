using System.Text.Json;
using System.Text.Json.Serialization;

namespace NewProgram.killTheEnemyGame;

public class GameCharacter
{
    public Guid Guid { get; set; } = Guid.NewGuid();
    public int Strength { get; set; } = 10;
    public string Name { get; set; }
    public Weapon Weapon { get; set; }
    public Health Health { get; set; } = new Health();
    public bool HasWeapon => Weapon != null;

    public void Fight(GameCharacter opponent)
    {
        //
        if (HasWeapon && opponent.HasWeapon)
        {
            if (this.Weapon.HitPoint >= opponent.Weapon.HitPoint)
            {
                opponent.Health.HealthPoint -= (int)(Weapon.HitPoint + Strength / 2);
                opponent.Health.Stamina -= (int)Strength / 4;

                Health.HealthPoint -= opponent.Strength / 10;
                Health.Stamina -= 2;
                
            }
            // check health status;;
        }
        else if (!HasWeapon && opponent.HasWeapon)
        {
            this.Health.HealthPoint -= opponent.Weapon.HitPoint + Strength;
        }
        else if (!opponent.HasWeapon && HasWeapon)
        {
            opponent.Health.HealthPoint -= Weapon.HitPoint + Strength;
        }
        else
        {
            if (Strength > opponent.Strength)
            {
                opponent.Health.HealthPoint -= Math.Abs(Strength - opponent.Strength);
                opponent.Health.Stamina -= Strength;
            }
                
        }

        Console.WriteLine($"Actor  Object => :{this.ToJson()} is fighting Opponent => : {opponent.ToJson()} ");
    }
}

public class Health
{
    public Health(int healthPoint = 100, int stamina = 100) // optional parameters
    {
        HealthPoint = healthPoint;
        Stamina = stamina;
    }

    public int HealthPoint { get; set; } = 100;
    public int Stamina { get; set; } = 100;
}

public class Weapon
{
    public int HitPoint { get; set; }
    public string Name { get; set; }
}

public class PlayGame
{
    public PlayGame()
    {
        GameCharacter actor = new GameCharacter(){Name = "Actor", Strength = 50};
        actor.Weapon = new Weapon() { Name = "Samurai Sword", HitPoint = 4 };
        GameCharacter enemy = new GameCharacter(){Name = "Enemy" , Strength = 40};
        enemy.Weapon =  new Weapon(){Name = "Nigerian Sword", HitPoint = 2};
        actor.Fight(enemy);
        actor.Fight(enemy);
        actor.Fight(enemy);
    }
}


public static class ObjectExtensions
{
    public static string ToJson(this object obj)
    {
        return JsonSerializer.Serialize(obj, new JsonSerializerOptions( JsonSerializerDefaults.Web));
    }
}
