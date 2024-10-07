using System;
using System.Collections.Generic;

public class Person
{
    private string nombre;
    private string apellido;
    private DateTime fecha;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime Fecha { get => fecha; set => fecha = value; }
}
