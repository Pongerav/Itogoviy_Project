Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine() ?? "0");

int sum = 0;
if (m > n)  for (int i = n; i < m+1; i += 1) sum += i;
else for (int i = m; i < n+1; i += 1) sum += i;
Console.WriteLine(sum);