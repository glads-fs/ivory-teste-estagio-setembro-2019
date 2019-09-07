using System;

namespace Questao2 {
    class Program 
    {
        static void Main(string[] args) 
        {
            string nome;

            Console.Write("Digite o nome: ");
            nome = Console.ReadLine();

            // Variavel com o tamanho do nome.
            int tamNome = nome.Length;

            // Variavel para determinar a quantidade de colunas da matriz.
            int tamanho = tamNome + 2;

            // Criação da matriz 
            int[,] matriz = new int[3,tamanho];

            // Variavel para colocar os números em volta do nome.
            var contador = 1;

            // Variavel para auxiliar na contagem da coluna para inserir o nome.
            var auxColuna = 1;

            // Variavel para definir o indice do vetor do nome.
            var x = 0;

            Console.Clear();
            Console.WriteLine("Nome digitado: {0}", nome);
            Console.WriteLine();
            Console.WriteLine("Matriz preenchida: ");
            Console.WriteLine();

            //Looping para imprimir a matriz com o nome dentro dela e os números no sentido horário.
            for (var linha = 0; linha < 3; linha++) 
            {
                for (var coluna = 0; coluna < tamanho; coluna++) 
                {
                    // Impressão da primeira linha da matriz com números no sentido horário.
                    if (linha == 0) 
                    {
                        Console.Write("{0}\t", contador);
                        contador++;
                    }
                    // Impressão da segunda linha da matriz.
                    else if (linha == 1)
                    {
                        if ((linha == 1) && (coluna == auxColuna) && (auxColuna <= tamNome)) 
                        {
                            // Impressão do nome na matriz.
                            Console.Write("{0}\t", nome[x]);
                            x++;
                            auxColuna++;
                        }
                        else 
                        {
                            if(coluna == 0) {
                                // Variavel contador recebendo o ultimo valor da contagem dos números.
                                contador = (3 * tamanho) - tamNome;
                                // Imprimindo o valor antes do nome.
                                Console.Write("{0}\t", contador);
                            }
                            else 
                            {
                                // Variavel contador recebendo o ultimo valor da contagem divido por dois.
                                contador = (3 * tamanho - tamNome) / 2;
                                // Imprimindo o valor depois do nome.
                                Console.Write("{0}\t", contador);
                            }
                            // Variavel contador recebendo o ultimo valor da contagem para decrementa-lo na terceira linha da matriz.                        
                            contador = (3 * tamanho) - tamNome;
                        }
                    }
                    // Impressão da terceira linha da matriz. 
                    else if(linha == 2)
                    {
                        // Variavel contador decrementando para continuar com os numeros no sentido horario.
                        contador--;
                        Console.Write("{0}\t", contador);
                    }                                      
                }
                // Quebra das linhas da matriz.
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
