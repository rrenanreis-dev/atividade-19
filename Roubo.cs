using System;
using BibliotecaVetor;
class Roubo
{
    static void exibirTop3BairrosViolentos(string[]bairros, int[] roubos)
    {
        int primeiro = 0;
        int  colocado1 = 0;
        int segundo = 0;
        int  colocado2 = 0;
        int terceiro = 0;
        int  colocado3 = 0;
        int guarda = 0;

        for (int i = 0; i < roubos.Length; i++)
    {
        if (roubos[i] > primeiro)
        {
            terceiro = segundo;
            colocado3 = colocado2;
            segundo = primeiro;
            colocado2 = colocado1;
            primeiro = roubos[i];
            colocado1 = i;
        }

        else if (roubos[i] > segundo)
        {
            terceiro = segundo;
            colocado3 = colocado2;
            segundo = roubos[i];
            colocado2 = i;
        }
        else if (roubos[i] > terceiro)
        {
            terceiro = roubos[i];
            colocado3 = i;
        }
    }

        Console.WriteLine($"\n1o Lugar: {bairros[colocado1]} (Indice {colocado1} ) - {primeiro} roubos");
        Console.WriteLine($"\n2o Lugar: {bairros[colocado2]} (Indice {colocado2} ) - {segundo} roubos");
        Console.WriteLine($"\n3o Lugar: {bairros[colocado3]} (Indice {colocado3} ) - {terceiro} roubos");
    }
    static double calcularMedia(int[] roubos)
    {
        int soma = 0;
        for(int i = 0; i < roubos.Length; i++)
        {
            soma += roubos[i];
        }

        double media = (double)soma/roubos.Length;

        return media;
    }
    static void Main()
    {
        string[] bairros = {"Centro", "Moema", "Pinheiros", "Itaquera", "Tatuapé",
        "Santo Amaro", "Vila Mariana", "Lapa", "Capão Redondo", "Santana"};

        int[] roubos = new int[bairros.Length];

        Vetor.lerVetor(roubos);
        Console.WriteLine("Dados do Vetor:");
        Vetor.mostrarVetor(roubos);

        double media = calcularMedia(roubos);
        Console.WriteLine($"\nMédia de roubos: {media:F2}");

       Console.WriteLine("\n--- TOP 3 BAIRROS MAIS VIOLENTOS ---");
       exibirTop3BairrosViolentos(bairros, roubos);
    }
}
