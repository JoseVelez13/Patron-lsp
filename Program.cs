using System;

// Clase base
public class Rectangulo
{
    public virtual int Altura { get; set; }
    public virtual int Ancho { get; set; }

    public int CalcularArea()
    {
        return Altura * Ancho;
    }
}

// Clase derivada que viola el LSP
public class Cuadrado : Rectangulo
{
    private int lado;

    public override int Altura
    {
        get => lado;
        set
        {
            lado = value;
            base.Altura = value;
            base.Ancho = value;
        }
    }

    public override int Ancho
    {
        get => lado;
        set
        {
            lado = value;
            base.Altura = value;
            base.Ancho = value;
        }
    }
}

class Program
{
    static void Main()
    {
        // Uso correcto del LSP
        Rectangulo rectangulo = new Rectangulo { Altura = 5, Ancho = 10 };
        Console.WriteLine($"Área del rectángulo: {rectangulo.CalcularArea()}");

        // Uso incorrecto del LSP (usando Cuadrado en lugar de Rectangulo)
        Rectangulo cuadrado = new Cuadrado { Altura = 5 };
        Console.WriteLine($"Área del cuadrado: {cuadrado.CalcularArea()}");
    }
}
