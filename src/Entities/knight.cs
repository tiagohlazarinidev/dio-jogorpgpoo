public class knight : Hero
{
  public knight(string Name, int Level, string heroType, int MP, int HP) : base(Name, Level, heroType, MP, HP)
  {
    this.Name = Name;
    this.Level = Level;
    this.heroType = heroType;
    this.MP = MP;
    this.HP = HP;
  }
}