
List<string> listaString = new List<string>();

listaString.Add("Lucas");
listaString.Add("Alexandre");
listaString.Add("Santana");


for (int i = 0; i < listaString.Count; i++)
{
    Console.WriteLine(listaString[i]);
}

Console.WriteLine();
foreach (string str in listaString)
{
    Console.WriteLine(str);
}