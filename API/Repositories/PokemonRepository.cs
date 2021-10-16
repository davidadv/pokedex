using System;
using System.Collections.Generic;
using ApiPokedex.Data;
using ApiPokedex.Models;
using Dapper;

namespace ApiPokedex.Repositories
{

    public class PokemonRepository
    {

        //CREATE INSERT
        public void Create(Pokemon pokemon)
        {
            var InsertPokemon = @"INSERT INTO POKEMONS VALUES(@PokemonId,
                                 @PokedexIndex,
                                 @Name,
                                 @Hp,
                                 @Attack,
                                 @Defense,
                                 @SpecialAttack,
                                 @SpecialDefense,
                                 @Speed,
                                 @Generation);
                                 
                                 INSERT INTO POKEMON_types VALUES(@PokemonTypeId,@PokemonId,@TypeId)";

            var Params = new
            {
                PokemonId = pokemon.Id,
                pokemon.PokedexIndex,
                pokemon.Name,
                pokemon.Hp,
                pokemon.Attack,
                pokemon.Defense,
                pokemon.SpecialAttack,
                pokemon.SpecialDefense,
                pokemon.Speed,
                pokemon.Generation,

                PokemonTypeId = Guid.NewGuid()




                
            };



            DataBase.Connection.Execute(InsertPokemon,Params); 

        }
         
        
        //SELECTALL

        public IEnumerable<Pokemon> GetAll (){
            var SelectAll = @"SELECT 
                            p.pokedex_index
                            ,p.Name 
                            ,p.HP 
                            ,p.Attack
                            ,p.Defense	
                            ,p.Special_Attack	
                            ,p.Special_Defense	
                            ,p.Speed	
                            ,p.Generation
                            ,T.type
                            FROM POKEMONS P
                            INNER JOIN POKEMON_types PT ON P.ID = PT.POKEMON_ID
                            INNER JOIN TYPES T ON PT.TYPE_ID = T.ID ";

            return new List<Pokemon>();
        }

    }
}