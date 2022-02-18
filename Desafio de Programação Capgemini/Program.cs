using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_de_Programação_Capgemini
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ////Questão 1
            Console.WriteLine("Primeira Questão!\n");
            //Solicitação que o usuario informe a quantidade de linhas desejadas
            Console.WriteLine("Qual o tamanho desejado?");
            int tamanho = Convert.ToInt32(Console.ReadLine());

            int ContEntradaFor3 = (tamanho - 1);
            int ContEntradaBreak = tamanho;

            //Primeiro for feito para quebrar um linha no final de cada loop
            for (int b = 0; b < tamanho; b++)
            {
                //Segundo for para gerar os espaços em branco
                for (int i = 0; i <= tamanho; i++)
                {
                    //Condição para entrada no terceiro for onde irar imprimir os *
                    //fazendo com que só entre quando i for igual a ContEntradaFor3
                    if (i == ContEntradaFor3)
                    {
                        //Terceiro for para que seja impresso os *
                        for (int j = tamanho; j > i; j--)
                        {
                            Console.Write("*");

                            //A cada loop do terceiro for ele vai decrementando o ContEntradaBreak
                            //que é o contador para entrada no if que libera o break para o segundo for
                            ContEntradaBreak--;
                        }
                        //Condição para que seja feita a parada do segundo for depois que preencha com os *
                        if (ContEntradaBreak <= i)
                        {
                            break;
                        }
                    }
                    Console.Write(" ");
                }
                //A cada loop do primeiro for ele vai decrementando o ContEntraFor3
                //que é o contador para entrada no terceiro for
                ContEntradaFor3--;
                Console.WriteLine();
            }

            Console.WriteLine("=======================================================================");

            //Questão 2
            Console.WriteLine("Segunda Questão!\n");
            //Solicitação que o usuario informe a senha desejada
            Console.WriteLine("Informe a Senha:");
            string senha = Console.ReadLine();

            //Pegar a senha digitada e transforma em um array de char para ficar mais facil
            //de fazer a comparação
            char[] caracteresSenha = senha.ToCharArray();

            bool caracter = false;

            bool numeros = false;

            bool minuscula = false;

            bool maiuscula = false;

            bool especial = false;

            //Primeira verificação para saber se a quantidade de digitos para senha possui
            //mais ou igual a 6 digitos
            if (caracteresSenha.Length >= 6)
            {
                caracter = true;
            }

            //For com a condição para verificar se a senha possui numeros caso positivo seta
            //o numeros para true
            for (int i = 0; i < caracteresSenha.Length; i++)
            {
                if (Char.IsDigit(caracteresSenha[i]))
                {
                    numeros = true;
                }
            }

            //For com a condição para verificar se a senha possui letras minusculas
            //caso positivo seta o minuscula para true
            for (int i = 0; i < caracteresSenha.Length; i++)
            {
                if (Char.IsLetter(caracteresSenha[i]))
                {
                    if (Convert.ToString(caracteresSenha[i]) == Convert.ToString(caracteresSenha[i]).ToLower())
                    {
                        minuscula = true;
                    }
                }
            }

            //For com a condição para verificar se a senha possui letras maiuscula
            //caso positivo seta o maiuscula para true
            for (int i = 0; i < caracteresSenha.Length; i++)
            {
                if (Char.IsLetter(caracteresSenha[i]))
                {
                    if (Convert.ToString(caracteresSenha[i]) == Convert.ToString(caracteresSenha[i]).ToUpper())
                    {
                        maiuscula = true;
                    }
                }
            }

            //Vetor que contem os caracteres especiais
            string[] caracterEspecial = new string[12] { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "+" };

            //For para pecorrer o vetor de CaracteresSenha
            for (int i = 0; i < caracteresSenha.Length; i++)
            {
                //For para pecorrer o vetor de caracterEspecial
                for (int j = 0; j < caracterEspecial.Length; j++)
                {
                    //Condição para verificar se no vetor CaracteresSenha possui algum dos caracteres especiais
                    //que contem no vetor caracterEspecial, caso positivo seta o especial para true
                    if (Convert.ToString(caracteresSenha[i]) == caracterEspecial[j])
                    {
                        especial = true;
                    }
                }
            }

            //Condição para verificar se atende aos requesitos, caso não ele entra e informa
            // ao usuario oque faltou
            if (caracter == false || numeros == false || minuscula == false
                || maiuscula == false || especial == false)
            {
                //Condição que informa se a quantidade de caracteres digitados na senha
                //satisfazem o necessario
                if (senha.Length <= 6)
                {
                    Console.Write($" Falta {6 - senha.Length} digitos para senha ser forte");
                }

                Console.WriteLine();

                //Informa o usuario que a condição de numeros foi valida ou não
                string verificacao = numeros ? "Validado" : "Nao Validado";
                Console.WriteLine($"Validacao de Digitos: {verificacao}");

                //Informa o usuario que a condição de minuscula foi valida ou não
                verificacao = minuscula ? "Validado" : "Nao Validado";
                Console.WriteLine($"Validacao de Minuscula: {verificacao}");

                //Informa o usuario que a condição de maiuscula foi valida ou não
                verificacao = maiuscula ? "Validado" : "Nao Validado";
                Console.WriteLine($"Validacao de Maiuscula: {verificacao}");

                //Informa o usuario que a condição de especial foi valida ou não
                verificacao = especial ? "Validado" : "Nao Validado";
                Console.WriteLine($"Validacao de Caracter Especial: {verificacao}");
            }
            else
            {
                Console.WriteLine("Senha Confirmada");
            }

            Console.WriteLine("=======================================================================");

            //Questão 3
            Console.WriteLine("Terceira Questão!\n");

            Console.WriteLine("Digite a palavra.");
            string anagrama = Console.ReadLine();

            //Criar um vetor com a palavra disgitada
            char[] caracteresAnagrama = anagrama.ToCharArray();

            //Criar um vetor do tamanho da string do anagrama
            char[] letrasIguais = new char[anagrama.Length];

            //Contador para saber se as letras são iguais
            int cont_letrasIguais = 0;

            for (int i = 1; i < caracteresAnagrama.Length; i++)
            {
                //Condição para verificar se chegou ao final do vetor e parar o for
                if (caracteresAnagrama[i] == ' ')
                {
                    break;
                }
                for (int j = 0; j < caracteresAnagrama.Length; j++)
                {
                    if (i != j)
                    {
                        //Condição para verificar se o vetor caracteresAnagrama na posição i
                        //é igual a posição do vetor caracteresAnagrama
                        if (caracteresAnagrama[i].Equals(caracteresAnagrama[j]))
                        {
                            letrasIguais[cont_letrasIguais] = caracteresAnagrama[i];
                            cont_letrasIguais++;
                            caracteresAnagrama[i] = ' ';
                            caracteresAnagrama[j] = ' ';
                            break;
                        }
                    }
                }
            }

            Console.ReadLine();

            //Não conseguir terminar essa questão.
        }
    }
}