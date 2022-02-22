public class Wizard : Hero
{
  public Wizard(string Name, int Level, string heroType, int MP, int HP) : base(Name, Level, heroType, MP, HP)
  {
    this.Name = Name;
    this.Level = Level;
    this.heroType = heroType;
    this.MP = MP;
    this.HP = HP;
  }

  public override string Attack() => $"{this.Name} Lançou Magia.";
  public string Attack(int Bonus)
  {
    if (Bonus > 6)
    {
      return $"{this.Name} Lançou Magia super efetiva Com bonus de {Bonus}";
    }
    else
    {
      return $"{this.Name} Lançou Magia com força franca com bonus de {Bonus}";
    }
  }
}
