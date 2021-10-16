using Npgsql;

namespace ApiPokedex.Data
{
    public static class DataBase
    {
        private static readonly string ConnectionString = "User ID=postgres;Password=alef123;Host=localhost;Port=5432;Database=Pokedex;Pooling=true;";

        public static NpgsqlConnection Connection = new NpgsqlConnection(ConnectionString);

        



    }
}