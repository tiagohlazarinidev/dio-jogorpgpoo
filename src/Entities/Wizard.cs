public class Wizard : Hero
{
    public Wizard(string Name, int Level, string heroType) : base(Name, Level, heroType)
    {
        this.Name = Name;
        this.Level = Level;
        this.heroType = heroType;
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
