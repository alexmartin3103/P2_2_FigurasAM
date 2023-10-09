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
    Rectangulo r = new(3, 3.9, Color.FromArgb(255, 50, 20, 34));
    Circulo c = new(4, Color.FromArgb(255, 0, 20, 35));
    TrianguloEquilatero te = new(3, Color.FromArgb(255, 0, 20, 40));

    Console.WriteLine(r);
    Console.WriteLine("Area:" + r.GetArea());
    Console.WriteLine(c);
    Console.WriteLine("Area" + c.GetArea());
    Console.WriteLine(te);
    Console.WriteLine("Area" + te.GetArea());

    r.setAltura(5);
    c.setRadio(2);
    te.setLado(10);

    Console.WriteLine(r);
    Console.WriteLine("Area:" + r.GetArea());
    Console.WriteLine(c);
    Console.WriteLine("Area" + c.GetArea());
    Console.WriteLine(te);
    Console.WriteLine("Area" + te.GetArea());


    List<Figura> li = new List<Figura>();
    li.Add(new Rectangulo(3, 3.9, Color.FromArgb(255, 50, 20, 34)));
    li.Add(new Circulo(4, Color.FromArgb(255, 0, 20, 35)));
    li.Add(new TrianguloEquilatero(3, Color.FromArgb(255, 0, 20, 40)));
    li.Add(r);
    li.Add(c);
    li.Add(te);

    foreach (Figura figuras in li)
    {
      figuras.setColor(Color.FromArgb(255, 0, 20, 40));
      Console.WriteLine(figuras);

    }



  }

}