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

System.Console.WriteLine("Pilha");

Stack<string> pilhaLivros = new Stack<string>();

pilhaLivros.Push(".NET");
pilhaLivros.Push("DDD");
pilhaLivros.Push("Código Limpo");

System.Console.WriteLine($"Livros para leitura: {pilhaLivros.Count}");

while(pilhaLivros.Count > 0)
{
    System.Console.WriteLine($"Próximo livro para a leitura: {pilhaLivros.Peek()}");
    System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso");
    System.Console.WriteLine($"Livros na fila: {pilhaLivros.Count}");
}