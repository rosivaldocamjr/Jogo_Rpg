namespace dotnet__poo.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            Random rnd = new Random();
            return $"{this.Name} Lançou Magia com poder de {Math.Floor(rnd.NextDouble()*10)}";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return $"{this.Name} Lançou Magia super efetiva com Bonus de {Bonus}";
            }
            else
            {
                return $"{this.Name} Lançou Magia fraca com Bonus de {Bonus}";
            }
        }
    }
}