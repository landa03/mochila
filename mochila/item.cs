using System;

namespace mochila
{
    class item
    {
        public string nombre{get; set;}
        public int peso{get;set;}
        public int ID{get;set;}

        public string getname()
        {
            Console.Write(nombre);
            return nombre;
        }
        //el nombre del objeto
        public item (string nombre, int peso, int ID)
        {
            this.nombre = nombre;
            this.peso = peso;
            this.ID = ID;
        }
    }
}
