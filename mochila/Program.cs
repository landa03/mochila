using System;

namespace mochila
{
    class Program
    {
        static void Main(string[] args)
        {
             //declara los objetos
            item c = new item("cuerda", 1000, 1);
            item pl = new item("platano", 80, 7);
            item a = new item("agua", 1100, 2);
            item m = new item("mansana", 250, 3);
            item p = new item("pan", 70, 4);
            item b = new item("vrijula", 350, 5);
            item pb = new item("papel", 350, 6);
            item no = new item("no", 0, 0);

            
            Inventario mochila = new Inventario(new item [3,4]
                {
                    {no, b, m, no},
                    {pl, c, a, p},
                    {pl, c, a, pb}
                },
                3, 4
            );
           mochila.printAray();
           mochila.verifica();
        }
    }
}
