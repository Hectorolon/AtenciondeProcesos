using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atencion_de_Procesos
{
    class Lista
    {
        Proceso inicio = null;
        Proceso ultimo = null;
        Proceso actual = null;

        public void agregar(Proceso nuevo)
        {
            if (inicio != null)
            {
                ultimo.siguiente = nuevo;
                nuevo.siguiente = inicio;
                ultimo = nuevo;
            }
            else
            {
                inicio = nuevo;
                inicio.siguiente = inicio;
                ultimo = nuevo;

                actual = inicio;
            }
        }

        public void eliminar()
        {
            if (inicio.siguiente != inicio)
            {
                inicio = inicio.siguiente;
                ultimo.siguiente = inicio;
            }
            else
            {
                inicio = null;
                ultimo = null;
            }

            //if (actual.siguiente != null)
            //{
            //    Proceso t = inicio;
            //    Proceso anterior = null;
            //    do
            //    {
            //        if (t == actual)
            //        {
            //            if (actual == inicio)
            //            {
            //                inicio = inicio.siguiente;
            //                ultimo = anterior;
            //            }
            //            else if (actual == ultimo)
            //            {
            //                ultimo = anterior;
            //            }
            //            else
            //            {
            //                anterior.siguiente = t.siguiente;
            //            }
            //        }
            //        anterior = t;
            //        t = t.siguiente;
            //    } while (t != inicio);
            //}
            //else
            //{
            //    inicio = null;
            //    ultimo = null;
            //}
        }

        public Proceso ver()
        {
            return actual;
        }

        public Proceso cambiar()
        {
            if (inicio != null)
            {
                Proceso anterior = inicio;
                if (inicio.siguiente != null)
                {
                    inicio = inicio.siguiente;
                    ultimo = anterior;
                }
                else
                    return inicio;
            }
            return null;

            //if (inicio != null)
            //{
            //    if (actual.siguiente != null)
            //    {
            //        actual = actual.siguiente;
            //        return actual;
            //    }
            //    else
            //        return inicio;
            //}
            //return null;
        }
    }
}
