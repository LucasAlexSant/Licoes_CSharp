
int[] arrayInteiros = new int[4];

arrayInteiros[0] = 1;
arrayInteiros[1] = 2;  
arrayInteiros[2] = 3;
arrayInteiros[3] = 4;

int[] arrayinteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayinteirosDobrado, arrayInteiros.Length); // copiando um array para outro

Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2); //redimensiona o tamanho do array


for (int i = 0; i < arrayInteiros.Length; i++) {

    Console.WriteLine(arrayInteiros[i]);
}

Console.WriteLine();

foreach(int valor in arrayinteirosDobrado)
{
    Console.WriteLine(valor);
}