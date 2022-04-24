namespace JogoRpg.src.Entities
{
  public abstract class Hero
  {
    public string Name { get; set; }
    public int MP { get; set; }
    public int HP { get; set; }
    public int Level { get; set; }
    public string HeroType { get; set; }

    public Hero() { }

    protected Hero(string name, int level, string heroType, int mP, int hP)
    {
      Name = name;
      MP = mP;
      HP = hP;
      Level = level;
      HeroType = heroType;
    }

    protected Hero(string name, int level, string heroType)
    {
      Name = name;
      Level = level;
      HeroType = heroType;
    }

    public override string ToString() => $"{Name} {Level} {HeroType}";

    public virtual string Attack() => $"{Name} Atacou com a sua espada.";
  }
}