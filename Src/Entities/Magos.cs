using System;

namespace JogoRPG.Src.Entities
{
    public class Magos : Personagem
    {
        public Magos (string Name, int Level, string HeroType) : base (Name, Level, HeroType)
        {
          this.Name = Name;
          this.Level = Level;
          this.HeroType = HeroType;
        }
       public override string Ataque()
        {
            return this.Name + " Lançou magia";
        }
        public string Ataque (int Bonus)
    {
        if (Bonus > 6){

            return this.Name + " Lançou  super magia com bonus de Ataque ";
        } 
        else {
            return this.Name + " Lançou magia fraca para Ataque ";
        }
            
    }
    }   
        
}