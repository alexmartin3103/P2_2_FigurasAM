
using System.Drawing;

namespace P2_2_Figuras;

internal class Circulo : Figura
{
    protected double _radio;

    public Circulo(double _radio, Color _color)
    {
        _radio = this._radio;
        _color = this._color;
    }

    public override double GetArea()
    {
        return _radio * _radio * Math.PI;
    }

    public double getRadio()
    {
        return this._radio;
    }
    public void setRadio(double radio)
    {
        this._radio = radio;
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
        return $"Radio: {this._radio} \n" + base.ToString();
    }
}