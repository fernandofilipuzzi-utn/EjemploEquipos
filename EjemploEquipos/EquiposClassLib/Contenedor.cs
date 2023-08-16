using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EquiposClassLib
{
    public class Contenedor
    {
        ArrayList equipos = new ArrayList();

        public void RegistrarEquipo(string nombre, string club, int puntos) 
        {
            equipos.Add(new Equipo { Nombre = nombre, Club = club, Puntos = puntos });
        }

        public ArrayList Listar()
        {
            for (int n = 0; n < equipos.Count-1; n++) 
            {
                for (int m = n+1; m < equipos.Count; m++)
                {
                    int p = ((Equipo)equipos[n]).Puntos;
                    int q = ((Equipo)equipos[m]).Puntos;
                    if (p < q)
                    {
                        Equipo aux = (Equipo)equipos[m];
                        equipos[m] = equipos[n];
                        equipos[n] = aux;
                    }
                }
            }
            return equipos;
        }
    }
}