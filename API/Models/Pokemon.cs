using System;

namespace ApiPokedex.Models
{

    public class Pokemon
    {
        public Guid Id { get; private set; }
        public int PokedexIndex { get; private set; }
        public string Name { get; private set; }
        public int Hp { get; private set; }
        public int Attack { get; private set; }
        public int Defense { get; private set; }
        public int SpecialAttack { get; private set; }
        public int SpecialDefense { get; private set; }
        public int Speed { get; private set; }
        public int Generation { get; private set; }


        public int Total => Hp + Attack + Defense + SpecialAttack + SpecialDefense + Speed;

        








    }


}