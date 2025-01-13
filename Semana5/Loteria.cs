// Archivo: NumerosLoteria.cs
using System;
using System.Collections.Generic;

public class NumerosLoteria
{
    private List<int> numerosGanadores;

    public NumerosLoteria()
    {
        numerosGanadores = new List<int>();
    }

    public void AgregarNumero(int numero)
    {
        numerosGanadores.Add(numero);
    }

    public List<int> ObtenerNumerosOrdenados()
    {
        numerosGanadores.Sort();
        return numerosGanadores;
    }
}
