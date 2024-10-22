using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc = 0; 
            int pos = 0; 
            int nodo = 0; 
            int lastValor; 
            int nuevo = 0;
            bool cambio;

           lista mylist = new lista();
           
            do
            {
                Console.Clear();
                Console.WriteLine("MENU LISTAS" +
                "\n---------------------------------" +
                "\n1.- Insertar Nodo" +
                "\n2.- Imprimir Tamaño" +
                "\n3.- Buscar Nodo" +
                "\n4.- Borrar Nodo" +
                "\n5.- Modificar Nodo" +
                "\n6.- Buscar Valor" +
                "\n7.- Imprimir Lista" +
                "\n8.- Salir" +
                "\n_____________________" +
                "\nSelecciónar Opción =>");

                Console.WriteLine("\nIngrese una opción:");
                opc = Convert.ToInt32(Console.ReadLine());

                switch(opc)
                {
                    case 1:
                        Console.Clear();
                        int valor = 0;
                        Console.WriteLine("1.- Insertar Nodo\n");
                        Console.WriteLine("Ingrese el valor del nodo:");
                        valor = Convert.ToInt32(Console.ReadLine());

                        mylist.Add(valor);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("2.- Imprimir Tamaño\n");
                        Console.WriteLine($"La cantidad de nodos existentes es: {mylist.Count()}");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("3.- Buscar Nodo\n");
                        Console.WriteLine("Ingrese la posición del valor a encontrar:");
                        pos = Convert.ToInt32(Console.ReadLine());
                        valor = mylist.Find(pos);
                        if(pos != -1)
                        {
                            Console.WriteLine($"\nLa posición: {pos}, tiene el valor: {valor}");
                        }
                        else
                        {
                            Console.WriteLine("\nError inesperado. Valor inválido o fuera de rango");
                        }
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("4.- Borrar Nodo\n");
                        Console.WriteLine("Ingrese el nodo a borrar:");
                        nodo = Convert.ToInt32(Console.ReadLine());
                        lastValor = mylist.Find(nodo);
                        if(mylist.Delete(nodo))
                        {
                            Console.WriteLine($"\nEl nodo: {nodo} con el valor: {lastValor} fué eliminado.");
                        }
                        else
                        {
                            Console.WriteLine("\nError inesperado.");
                        }                      
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("5.- Modificar Nodo\n");
                        Console.WriteLine("Ingrese la posición del valor a cambiar:");
                        pos = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nIngrese el nuevo valor:");
                        nuevo = Convert.ToInt32(Console.ReadLine());

                        mylist.Change(pos, nuevo);

                        if (cambio = true)
                        {
                            Console.WriteLine($"\nLa posición: {pos}, tiene un nuevo valor: {nuevo}");
                        }
                        else
                        {
                            Console.WriteLine($"\nNo se puedo cambiar el valor de la posición: {pos}.");
                        }
                        Console.ReadKey();


                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("6.- Buscar Valor\n");
                        Console.WriteLine("Ingrese el valor  de la posición a encontrar:");
                        valor = Convert.ToInt32(Console.ReadLine());
                        pos = mylist.FindValue(valor);
                        if (pos != -1)
                        {
                            Console.WriteLine($"\nEl valor: {valor}, tiene la posición: {pos}");
                        }
                        else
                        {
                            Console.WriteLine("\nError inesperado. El valor no existe.");
                        }
                        Console.ReadKey();

                        break;
                    case 7:
                        Console.WriteLine("7.- Imprimir Lista\n");
                        Console.Clear();
                        Console.WriteLine("Los valores del nodo son:");
                        mylist.Print();
                        Console.ReadKey();
                        break;
                    case 8:
                        if(opc == 8)
                        {
                            Console.WriteLine("\nSaliendo del programa...");
                        }
                        break;
                }
                
            } while (opc != 8);
        }
    }
}