using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class lista
    {
        nodo inicio;

        public lista()
        {
            inicio = null;
        }

        public void Add(int num)
        {
            nodo nuevo = new nodo(num);
            if (inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                nodo act = inicio;
                while (act.Sig != null)
                    act = act.Sig;
                act.Sig = nuevo;

            }
        }

        public void Print()
        {
            if (inicio == null)
                Console.WriteLine("Lista vacía");
            else
            {
                nodo act;
                act = inicio;
                while (act != null)
                {
                    Console.WriteLine($"{act.Valor}");
                    act = act.Sig;
                }
            }
        }
        public int Find(int pos)
        {
            //Regresa el valor que esta en la posición indicada, si no encuentra la posición o la lista está vacía regresa -1
            if (inicio == null || pos < 0)
            {
                return -1;
            }

            nodo actual = inicio;
            int cont = 0;

            while (actual != null)
            {
               if(cont == pos)
                {
                    return (int)actual.Valor;
                }
                cont++;
                actual = actual.Sig;
            }
            return -1;

        }

        public bool Delete(int pos)
        {
            //Elimina el nodo en la posición indicada y regresa true si eliminó exitosamente, si la lista esta vacía o no encuentra la posición, regresa false
            if (inicio == null || pos < 0)
            {
                return false;
            }
            if (pos == 0)
            {
                inicio = inicio.Sig;
                return true;
            }

            nodo actual = inicio;
            for (int i = 0; i < pos - 1; i++)
            {
                if (actual == null || actual.Sig == null)
                {
                    return false;
                }
                actual = actual.Sig;
            }
             if(actual.Sig == null)
            {
                return false;
            }
            actual.Sig = actual.Sig.Sig; 
            return true;
        }
        public bool Change(int pos, int num)
        {
            //Asigna el nuevo valor en la posición indicada. si el cambio es exitoso, regresa true si no encuentra el nodo, o la lista está vacía y regresa un false
            if (inicio == null || pos < 0)
            {
                return false;
            }
            nodo actual = inicio;
            int cont = 0;

            while (actual != null) 
            { 
                if(cont == pos)
                {
                    actual.Valor = num;
                    return true;
                }
                cont++;
                actual = actual.Sig;
            
            }
            return false;
        }

        public int Count()
        {
            //Regresa la cantidad de nodos de la lista, si la lista está vacía regresa 0
            int contador = 0;
            nodo actual = inicio;
            if (actual == null)
            {
                Console.WriteLine("La lista está vacía.");
            }
            else
            {
                while (actual != null)
                {
                    contador++;
                    actual = actual.Sig;
                }
            }
            return contador;

        }

        public int FindValue(int num)
        {
            if (inicio == null)
            {
                return -1;
            }
           
            nodo actual = inicio;      
            int cont = 0;
            while(actual != null)
            {
                if (actual.Valor.Equals(num))
                {
                    return cont;
                }
                cont++;
                actual = actual.Sig;
                
            }
             return -1;
        }
    }
}
