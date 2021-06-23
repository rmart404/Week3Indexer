namespace indexers
{
  public class Dragon
  {
    public string Name { get; set; }
    public int Health { get; set; } = 100;

    public Dragon() { }
    public Dragon(string name, int health)
    {
      Name = name;
      Health = health;
    }

    public void damage(int hit)
    {
      if (hit > 0)
      {
        Health -= hit;
      }
    }

    public override string ToString()
    {
      return $"Dragon {Name} have a health of {Health}";
    }
  }
}