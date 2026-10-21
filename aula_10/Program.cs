using System;
using System.Reflection;
namespace Exercicio1
{
class Program
{
    public class Retangulo
        {
            public double Altura;
            public double Largura;

            public double Calc_area()
            {
                return Altura * Largura;
            }
            public double Peri()
            {
                return Altura + Largura + Altura + Largura;
            }
        }
    static void Main(string[] args)
    {
            Retangulo ret = new Retangulo();
            Console.WriteLine("digite Altura e Largura");
            ret.Altura = double.Parse(Console.ReadLine()!);
            ret.Largura = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Area:" + ret.Calc_area());
            Console.WriteLine("Perimetro:" + ret.Peri());
    }
}
}