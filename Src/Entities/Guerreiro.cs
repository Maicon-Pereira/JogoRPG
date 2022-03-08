namespace JogoRPG.Src.Entities
{
    public class Guerreiro : Personagem
    {
        public Guerreiro (string Name, int Level, string HeroType) : base (Name, Level, HeroType)
        {
          this.Name = Name;
          this.Level = Level;
          this.HeroType = HeroType;
        }
       public override string Ataque()
        {
            return this.Name + " Lançou ataque com lança dupla";
        }
        public string Defesa()
        {
            return this.Name + " Defendeu golpe do inimigo";
        }
    }
}