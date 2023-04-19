public class Enemy
{
    public int Health { get; set; }
    public int Strength { get; set; }
    public int Location { get; set; }
    
    public void Move(int direction)
    {
        // Move the enemy in a certain direction
    }
    
    public void Attack(Player player)
    {
        // Initiate combat with the player
    }
}

public class Zombie : Enemy
{
    public Zombie(int location)
    {
        Health = 50;
        Strength = 10;
        Location = location;
    }
    
    public void Move(int direction)
    {
        // Move the zombie in a certain direction, with a chance of randomly changing direction
    }
    
    public void Attack(Player player)
    {
        // Initiate combat with the player, with a chance of infecting them with the zombie virus
    }
}
