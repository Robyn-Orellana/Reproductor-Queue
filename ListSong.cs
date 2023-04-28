using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor01
{
    internal class ListSong
    {
       
        private Cancion inicio;
        //Aca empiezan los cambios 
        protected int fin;
        private static int MAXTAMQ = 5;
        protected int frente;
        protected Object[] listacola;


        public ListSong()
        {
            frente = 0;
            fin = -1;
            listacola = new object[MAXTAMQ];

        }

        public Boolean colallena()
        {
            return fin == MAXTAMQ - 1;
        }

        public Boolean colaVacia()
        {
            return frente > fin;
        }
        public void insertar(Cancion cancion)
        {
            if (!colallena())
            {
                listacola[++fin] = cancion;
            }
            else
            {
                borrarCola();
                throw new Exception("Cola Llena");
            }
        }

        public void borrarCola()
        {
            frente = 0;
            fin = -1;
        }

        public Object frenteCola()
        {
            if (!colaVacia())
            {
                return listacola[frente];
            }
            else
            {
                throw new Exception("Cola Vacia");
            }
        }

        public object quitar()
        {

            if (!colaVacia())
            {
                return listacola[frente++];
            }
            else
            {
                throw new Exception("Cola vacia");
            }
        }

    }
}

