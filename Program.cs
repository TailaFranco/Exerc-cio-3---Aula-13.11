using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa para calculo de aumento nos salários de funcionários que recebam menos de R$500,00.
            //O aumento para os funcionários que tenham direito será de 30%.
            //Para os funcionários que não se enquadrem  no ajuste aparecerá a mensagem que o funcionário não tem direito ao aumento.

            float reajuste;

            Console.WriteLine("Escreva o valor do salário. - Apenas números");
            float salario = float.Parse(Console.ReadLine());

            if(salario <500){
                reajuste = salario * 13/10;
                Console.WriteLine("Salário com reajuste - "+reajuste+"");
            }
            else{
                Console.WriteLine("O funcionário não tem direito ao aumento no salário");
            }
        }
    }
}
