//necesario para usar la estructura Color
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color?view=net-7.0
using System.Drawing;
//método para obtener un color a partir de los valores RGBA 
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color.fromargb?view=net-7.0

namespace P2_2_Figuras;

public class P2_2_Figuras
{
  static void Main(string[] args)
  {
    Rectangulo r = new(3, 4, Color.FromArgb(255, 50, 20, 34));
    Circulo c = new(5, Color.FromArgb(255, 50, 20, 34));
    TrianguloEquilatero te = new(10, Color.FromArgb(255, 50, 20, 34));

    Console.WriteLine(r);
    Console.WriteLine(c);
    Console.WriteLine(te);
    Console.WriteLine("Area:" + r.GetArea());
    Console.WriteLine("Area" + c.GetArea());
    Console.WriteLine("Area" + te.GetArea());


  }

}