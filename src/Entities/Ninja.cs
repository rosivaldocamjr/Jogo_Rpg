namespace dotnet__poo.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            Random rnd = new Random();
            return $"{this.Name} Lançou Shuriken com poder de {Math.Floor(rnd.NextDouble()*10)}";
        }
    }
}