namespace JogoRPG.Src.Entities
{
    public class Ninja : Personagem
    {
        public Ninja (string Name, int Level, string HeroType) : base (Name, Level, HeroType)
        {
          this.Name = Name;
          this.Level = Level;
          this.HeroType = HeroType;
        }
       public override string Ataque()
        {
            return this.Name + " Lançou golpe de Kusarigama";
        }
    }
}