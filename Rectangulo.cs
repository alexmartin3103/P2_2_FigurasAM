using System.Drawing;
using System.Reflection.Metadata.Ecma335;

namespace P2_2_Figuras;

internal class Rectangulo : Figura
{
    protected double _base;
    protected double _altura;
    protected Rectangulo(double _altura, double _base, Color _color)
    {
        _altura = this._altura;
        _base = this._base;
        _color = this._color;
    }

    public override double GetArea()
    {
        return this._base * this._altura;
    }

    public override string ToString()
    {
        return $"Alto: {this._altura} \n Ancho:{this._base} \n" + base.ToString();
    }
    public double getAltura()
    {
        return this._altura;
    }
    public double getBase()
    {
        return this._base;
    }
    public Color getColor()
    {
        return this._color;
    }
    public void setAltura(double altura)
    {
        _altura = altura;
    }
    public void setBase(double basee)
    {
        _altura = basee;
    }
    public void setColor(Color color)
    {
        _color = color;
    }
}