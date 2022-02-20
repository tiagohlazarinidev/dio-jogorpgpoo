public abstract class Hero
{
    public string Name { get; set; }
    public int Level { get; set; }
    public string heroType { get; set; }

    public Hero(string Name, int Level, string heroType)
    {
        this.Name = Name;
        this.Level = Level;
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