using System.Drawing;

namespace P2_2_Figuras;

internal class TrianguloEquilatero : Figura
{
    protected double _lado;

    public TrianguloEquilatero(double _lado, Color _color)
    {
        _lado = this._lado;
        _color = this._color;
    }

    public override double GetArea()
    {
        return (Math.Sqrt((_lado * _lado) - ((_lado / 2) * (_lado / 2))) * _lado) / 2;
    }
    public double getLado()
    {
        return this._lado;
    }
    public void setLado(double lado)
    {
        this._lado = lado;
    }
    public Color getColor()
    {
        return this._color;
    }
    public void setColor(Color color)
    {
        _color = color;
    }
    public override string ToString()
    {
        return $"Lado: {this._lado} \n" + base.ToString();
    }
}