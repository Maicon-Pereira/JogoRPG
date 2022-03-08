namespace JogoRPG.Src.Entities
{
    public class Inimigo : Personagem
    {
        public Inimigo (string Name, int Level, string HeroType) : base (Name, Level, HeroType)
        {
          this.Name = Name;
          this.Level = Level;
          this.HeroType = HeroType;
        }
       public override string Ataque()
        {
            return this.Name + " atacou os guerreiros com lança chamas";
        }
    }
}