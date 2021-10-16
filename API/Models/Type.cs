using System;

namespace ApiPokedex.Models
{
    public class Type
    {
        public Guid Id { get; private set; }
        public string TypePokemon { get; private set; }
    }
}