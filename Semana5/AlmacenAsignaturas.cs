// Archivo: Asignaturas.cs
using System;
using System.Collections.Generic;

public class Asignaturas
{
    private List<string> listaAsignaturas;

    public Asignaturas()
    {
        listaAsignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
    }

    public List<string> ObtenerAsignaturas()
    {
        return listaAsignaturas;
    }
}
