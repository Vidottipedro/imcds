using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imc
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int Obesos = 0;
            int saudaveis = 0;
            String[] nome = new String[5];
            Double[] altura = new Double[5];
            Double[] peso = new Double[5];
            Double[] IMC = new Double[5];
            String[] estado = new String[5];

            for (int i = 0; i <=4 ; i++) {
                Console.WriteLine("Insira o nome da pessoa: ");
                nome[i] = Console.ReadLine();
                Console.WriteLine("Insira a altura em metros da pessoa: ");
                altura[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Insira o peso da pessoa: ");
                peso[i] = double.Parse(Console.ReadLine());

                IMC[i] =   peso[i]/Math.Pow(altura[i], 2);

                if (IMC[i]<18.51) {
                    estado[i] = "Abaixo do Peso";
                    saudaveis++;
                
                }else if (IMC[i] < 24.91)
                {
                    estado[i] = "Peso Ideal";
                    saudaveis++;
                }
                else if (IMC[i] < 29.91)
                {
                    estado[i] = "Levemente acima do peso";
                    Obesos++;
                }
                else if (IMC[i] < 34.91)
                {
                    estado[i] = "Obesidade Grau I";
                    Obesos++;
                }
                else if (IMC[i] < 39.91)
                {
                    estado[i] = "Obesidade Grau II";
                    Obesos++;
                }
                else { 
                    estado[i] = "Obesidade Grau III";
                    Obesos++;
                }
            }
            for (int j = 0;j <=4 ;j++) 
            {
                Console.WriteLine
                    (
                    "O(A) " + nome[j]+ " tem um IMC de " 
                    + IMC[j]+" e está em um estado de " + estado[j]
                    );
                Console.WriteLine("Há " + Obesos + " pessoas acima do peso e " 
                    + saudaveis + "pessoas saudáveis, logo o percentual de pessoas obesas é de: " 
                    +  Obesos/5+"%");
            }
            Console.ReadKey ();
        }
    }
}
