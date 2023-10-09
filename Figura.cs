using System.Drawing;
using System.Dynamic;

namespace P2_2_Figuras;

internal abstract class Figura
{
  protected Color _color;


  public override string ToString()
  {
    System.ComponentModel.TypeConverter converter =
        System.ComponentModel.TypeDescriptor.GetConverter(_color);
    return $"Color: {converter.ConvertToString(_color)}";
  }
  public abstract double GetArea();

}