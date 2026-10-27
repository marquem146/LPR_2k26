using System;

namespace exercicio2
{
    class Program
    {
        public class Funcionario
        {
            public string nome;
            public double salario;

            public Funcionario(string n, double s)
            {
                nome = n;
                salario = s;
            }
            public double calc_imposto()
            {
                if(salario >= 2000)
                {
                    return salario *0.10;
                }
                else if( salario >= 3000)
                {
                    return salario * 0.15;
                }
                else
                {
                    return salario * 0.20;
                }
            }
        }
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario("Marcos", 2000.000);
            Funcionario f2 = new Funcionario("Layon", 3000.000);

            Console.WriteLine("Funcionario1:" + f1.nome + " salario:"+ " "+ f1.salario);
            Console.WriteLine("Funcionario2:" + f2.nome + " salario:"+ " "+ f2.salario);
            Console.WriteLine("Imposto do Funcionario1:" +" "+ f1.calc_imposto());
            Console.WriteLine("Imposto do Funcionario2:" +" "+ f2.calc_imposto());
            
            
        }
    }
}
