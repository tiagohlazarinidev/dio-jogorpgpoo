public abstract class Hero
{
  public string Name { get; set; }
  public int MP { get; set; }
  public int HP { get; set; }
  public int Level { get; set; }
  public string heroType { get; set; }



  public Hero(string Name, int Level, string heroType, int MP, int HP)
  {
    this.Name = Name;
    this.Level = Level;
    this.heroType = heroType;
    this.MP = MP;
    this.HP = HP;
  }

  protected Hero(string name, int level, string heroType)
  {
    Name = name;
    Level = level;
    this.heroType = heroType;
  }

  public override string ToString()
  {
    return $"{this.Name} {this.Level} {this.heroType}";
  }

  public virtual string Attack() // qualquer filho pode sobreescrever
  {
    return $"{this.Name} Atacou com a sua espada.";
  }
}