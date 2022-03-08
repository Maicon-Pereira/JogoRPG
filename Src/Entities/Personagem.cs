namespace JogoRPG.Src.Entities
{
    public abstract class Personagem
    {
        public Personagem(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public string Name;
        public int Level;
        public string HeroType;

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }
        public virtual string Ataque()
        {
            return this.Name + " Atacou com a sua espada";
        }
    }
}