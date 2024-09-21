int[] arrayInteiro = new int[4]; 

arrayInteiro[0] = 72;
arrayInteiro[1] = 13;
arrayInteiro[2] = 51;
arrayInteiro[3] = 78;

Console.WriteLine("Percorrendo array com For");

for (int contador = 0; contador < arrayInteiro.Length; contador++)
{
    Console.WriteLine($"Posição Nº {contador} - {arrayInteiro[contador]}");
}

Console.WriteLine("Percorrendo array com forEach");

foreach(int valor in arrayInteiro){
    Console.WriteLine(valor);
}