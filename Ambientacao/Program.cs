
int auxiliar = 0;
int tamanho = 1000;
Boolean troca = false;
int[] vetor = new int[tamanho];

//Tipo variavel = new(); esse new já entende qual tipo está sendo definido na variavel então não precisa escrever
// new Random();
Random random = new();

//Limpar console
Console.Clear();

//Gerando os valores aleatórios
for(int i = 0; i < tamanho; i++)
{
    vetor[i] = random.Next(0, 1500);
}

//Imprimindo vetor sem ordenar
ImprimirVetor();

//Função de ordenação
//Array.Sort(vetor);
do{
    troca = false;
    for(int i = 0; i < tamanho - 1; i++)
    {
        if(vetor[i] > vetor[i + 1])
        {
            auxiliar = vetor[i];
            vetor[i] = vetor[i + 1];
            vetor[i + 1] = auxiliar;
            troca = true;
        }
    }
} while(troca);

//Imprimindo vetor ordenando
ImprimirVetor();

//Método para realizar a impressão
void ImprimirVetor()
{
    for(int i = 0; i < tamanho; i++ )
    {
        Console.WriteLine(vetor[i] + "");
    }
    Console.WriteLine("\n");
}