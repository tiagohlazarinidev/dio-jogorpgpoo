namespace JogoRpg.src.Entities
{
  public class Wizard : Hero
  {
    public Wizard(string name, int level, string heroType, int mp, int hp) : base(name, level, heroType, mp, hp) { }

    public override string Attack() => $"{Name} Lançou Magia.";

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
}