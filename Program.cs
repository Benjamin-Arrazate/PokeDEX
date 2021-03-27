using System;
using System.Collections.Generic;

namespace PokeDEX
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Estos son los nombres y ID's de todos lo Pokemon que hay en el PokeDEX actualmente: ");

            Dictionary<string,int> POKEMONANDID = new Dictionary<string, int>();
            POKEMONANDID.Add("Pikachu", 25); 
            POKEMONANDID.Add("Gengar", 94);
            POKEMONANDID.Add("Charizard", 06);
            POKEMONANDID.Add("Lucario", 448);
            POKEMONANDID.Add("Greninja", 658);
            POKEMONANDID.Add("Bulbasur", 01);
            POKEMONANDID.Add("Eevee", 133);
            POKEMONANDID.Add("Dragonite", 149);
            POKEMONANDID.Add("Mew", 151);
            POKEMONANDID.Add("Mewtwo", 150);

            foreach (var key in POKEMONANDID.Keys)
            {
                Console.WriteLine("Nombre: " + key + " - " + ("ID: ") + POKEMONANDID.GetValueOrDefault(key)); 
            }

            Console.WriteLine("---------");

            // En esta seccion es donde usted podra consultar cualquier Pokemon y se imprimira su nombre y su ID (O puede ser cada uno individualmente.)
            Pokemon Pikachu = new Pokemon("Pikachu", 25);

            Pikachu.MostrarPokemonyID(); 
            Pikachu.MostrarsoloNombre();
            Pikachu.MostrarsoloID();
            
            
            Console.WriteLine("---------");

            List<String> NombresPokemonParty = new List<string>();
             NombresPokemonParty.Add("Pikachu"); 
             NombresPokemonParty.Add("Charizard"); 
             NombresPokemonParty.Add("Mewtwo"); 
             NombresPokemonParty.Add("Eevee"); 
             NombresPokemonParty.Add("Mew"); 
             NombresPokemonParty.Add("Dragonide"); 


             List<Pokemon> PokemonParty = new List<Pokemon>();
             PokemonParty.Add(new Pokemon("Pikachu", 25, "Male")); 
             PokemonParty.Add(new Pokemon("Charizard", 25, "Male")); 
             PokemonParty.Add(new Pokemon("Mewtwo", 25, "Male")); 
             PokemonParty.Add(new Pokemon("Eevee", 25, "Male")); 
             PokemonParty.Add(new Pokemon("Mew", 25, "Male")); 
             PokemonParty.Add(new Pokemon("Dragonide", 25, "Male")); 

            Console.WriteLine("Estos son los Pokemon que hay en la party actualmente: ");

            string items = string.Join(Environment.NewLine, NombresPokemonParty);

            Console.WriteLine(items);

            Console.WriteLine("Cant. de Pokemon dentro de la party: " + PokemonParty.Count); 

            Console.WriteLine("---------");


            Console.WriteLine("Version del programa: pokedex.byzeittstudios.version.1.0.");

        }
    }
}