int[] arrayNumeros = new int[10] { 100, 1, 4, 0, 8, 15, 19, 19, 4, 100};

// Sintaxe
var numerosPares = 
    from num in arrayNumeros
    where num % 2 == 0
    orderby num
    select num;

var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

var minimo = arrayNumeros.Min();
var maximo = arrayNumeros.Max();
var medio = arrayNumeros.Average();

var soma = arrayNumeros.Sum();
var somaDistinct = arrayNumeros.Distinct().Sum();
var arrayUnico = arrayNumeros.Distinct().ToArray();

System.Console.WriteLine("Utilizando sintaxe");
System.Console.WriteLine("Números pares query: " + string.Join(", ", numerosPares));

System.Console.WriteLine("------");

System.Console.WriteLine("Utilizand método");
System.Console.WriteLine("Números pares método: " + string.Join(",", numerosParesMetodo));

System.Console.WriteLine("------");
System.Console.WriteLine($"Mínimo: {minimo}");
System.Console.WriteLine($"Máximo: {maximo}");
System.Console.WriteLine($"Médio: {medio}");

System.Console.WriteLine("------");
System.Console.WriteLine($"Soma: {soma}");
System.Console.WriteLine($"Array original: {string.Join(", ", arrayNumeros)}");
System.Console.WriteLine($"Array distinto: {string.Join(", ", arrayUnico)}");
System.Console.WriteLine($"Soma array distinto: {somaDistinct}");
