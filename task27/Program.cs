Console.Clear();
Console.WriteLine("Введите число:");
string N1 = Console.ReadLine();
char[] minus = {'-'};
 N1 = N1.TrimStart(minus);

int result = 0;

for (int i = 0; i < N1.Length; i++)
{
    result = result+N1[i];
}


    Console.WriteLine(int.Parse(result.ToString()));
