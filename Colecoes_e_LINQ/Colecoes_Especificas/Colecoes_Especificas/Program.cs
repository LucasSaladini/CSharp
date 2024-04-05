Queue<string> fila = new Queue<string>();

fila.Enqueue("Lucas");
fila.Enqueue("Eduardo");
fila.Enqueue("André");

System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

while (fila.Count > 0)
{
    System.Console.WriteLine($"Vez de: {fila.Peek()}");
    System.Console.WriteLine($"{fila.Dequeue()} atendido");
    System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

}
