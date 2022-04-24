namespace JogoRpg.src.Entities
{
  public class Knight : Hero
  {
    public Knight(string name, int level, string heroType, int mP, int hP) : base(name, level, heroType, mP, hP) { }

    public override string Attack() => base.Attack();
  }
}