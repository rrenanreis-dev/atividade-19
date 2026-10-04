using System;
using BibliotecaMatriz;
class Desmatamento
{
    static void analisarAumento(int[,]matriz6meses , int[,] matrizAtual)
    {
        double anterior = calcularPercentuaDesmatamento(matriz6meses)[0];
        double atual = calcularPercentuaDesmatamento(matrizAtual)[0];
        Console.WriteLine("\nPercentual de ocorrências na matriz 6 meses atrás:");
        Console.WriteLine($"\nÁrea Desmatada (Código 0): {anterior:F2}%");
        Console.WriteLine("\nPercentual de ocorrências na matriz atual:");
        Console.WriteLine($"\nÁrea Desmatada (Código 0): {atual:F2}%");
        if(atual > anterior){
            Console.WriteLine($"\nHouve Aumento no Desmatamento – Anterior {anterior:F2}% -> Atual {atual:F2}%");
        }
        else
        {
            Console.WriteLine("\nNão houve Aumento no Desmatamento");
        }
    }
    static double[] calcularPercentuaDesmatamento(int[,] matriz)
    {
        double soma = 0;
        for(int i = 0; i < matriz.GetLength(0); i++)
        {
            for(int j = 0; j < matriz.GetLength(1); j++)
            {
                if(matriz[i,j] == 0)
                {
                    soma++;
                }
            }
        }
        double[] porcentual = new double[3];
        porcentual[0] = ((double)soma*100)/matriz.Length;
        return porcentual;
    }
    static void Main()
    {
        int[,] matriz6meses = Matriz.carregarMatriz("dados_matriz_6meses_atras.csv");
        int[,] matrizatual = Matriz.carregarMatriz("dados_matriz_atual.csv");
        
        Console.WriteLine("Matriz de 6 meses atras: ");
        Matriz.mostrarMatriz(matriz6meses);
        Console.WriteLine("\nMatriz atual: ");
        Matriz.mostrarMatriz(matrizatual);

        analisarAumento(matriz6meses, matrizatual);

    }
}

