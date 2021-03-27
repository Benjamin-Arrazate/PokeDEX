using System;

namespace PokeDEX
{
    class Pokemon
    {
        string nombre;
        int ID;

        string genero; 

        public string NombreyID
        {
            get => this.nombre + " - " + this.ID; 
        }

        public Pokemon (String nombre, int ID)
        {
            this.nombre=nombre;
            this.ID=ID; 

        }



        public Pokemon (string nombre, int ID, string genero)
        {
            this.nombre=nombre;
            this.ID=ID;
            this.genero=genero; 



        }

        public void MostrarPokemonyID()
        {
            Console.WriteLine("Este es el nombre Y iD del Pokemon solicitado: " + NombreyID); 
        }

        public void MostrarsoloNombre()
        {
            Console.WriteLine("Este es el nombre del Pokemon: " + nombre); 
        }

        public void MostrarsoloID()
        {
            Console.WriteLine("Este es el ID del Pokemon: " + ID); 
        }

    }
    
}