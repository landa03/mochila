using System;

namespace mochila
{
    public class Inventario
    {
        private item[,] grid;
        private int gridHi;
        private int gridYd;
        public Inventario (item [,] gridValues, int gridHi, int gridYd)
        {
            this.grid = gridValues;
            this.gridHi = gridHi;
            this.gridYd = gridYd;

        }
        
        public void printAray()
        {
            //gridHi es la altura de mi mochila
            for (int y = 0; y < gridHi; y++)
            {
                //gridYd es el ancho
                for (int x = 0; x < gridYd; x++)
                {
                    //TO DO: hacer que me diga nombres enves de numeros
                    //no supe como consegir que por medio de la ID o el objeto, me diga su nombre
                    if(grid[y,x] = this.ID)
                    {
                        Console.WriteLine(this.nombre);
                    }
                }
                Console.WriteLine();
            }
        }
        //TO DO: hacer la suma de peso y verificar que el orden sea aceptable
        public void verifica()
        {
            //intente ver si el peso de mi objeto era menor a que el del objeto de arriva
            if (grid[y,x].peso < grid[y + 1,x])
            {
                //en dicho caso que me diga quien aplasto a quien
                Console.WriteLine($"{grid[y,x].nombre} aplasto {grid[y + 1, x].nombre}");
            }
        }
    }
}
//por lo meno no me rendi
//espero en un futuro encontrar esto y decir "como estava soquete esto esta vien facil"
//en caso de que lo lea sevastian
//{no seas huevon y has el tuyo aunque este mal}