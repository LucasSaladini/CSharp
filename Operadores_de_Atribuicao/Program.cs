// int a = 10;
// int b = 20;

// int c = a + b;

// c += 5;
// c -= 5;

// Console.WriteLine(c);


// Casting
// int a = Convert.ToInt32("5");
// int a = int.Parse("5");
// int inteiro = 5;
// string a = inteiro.ToString();

// int a = 5;
// double b = a;

// Console.WriteLine(b);

string a = "15-";

int b = 0;

int.TryParse(a, out b);

Console.WriteLine(b);
Console.WriteLine("Conversão realizada com sucesso");