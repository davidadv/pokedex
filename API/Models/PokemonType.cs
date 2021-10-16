using System;

namespace ApiPokedex.Models
{
    public class PokemonType
    {
        public Guid Id { get; private set; }
        public Guid PokemonId { get; private set; }
        public Guid TypeId { get; private set; }


    }
}