//Решение через int

// Console.Clear();
// Console.WriteLine("Введите пятизначное число:");
// int N1 = Convert.ToInt32(Console.ReadLine());

// while (N1>=100000 && N1<=-100000|| N1<10000 && N1>-10000)
// {Console.Write("Вы ошиблись!\nВведите пятизначное число:");
//     N1 = Convert.ToInt32(Console.ReadLine());
// }
// int right = N1%100;
// while (N1 >= 100||N1<=-100)
//         {
//             N1 /= 10;
// }

// int left =N1;
// if (left==right)

//     Console.WriteLine("Ваше число полиндром!");

// else

//     Console.WriteLine("Ваше число не полиндром!");

// Console.WriteLine(left);
// Console.WriteLine(right);

// Решение через стринг

Console.Clear();
Console.WriteLine("Введите пятизначное число:");
string N1 = Console.ReadLine();
char[] minus = {'-'};
 N1 = N1.TrimStart(minus);
 while (N1.Length!=5)

{
    Console.Write("Вы ошиблись!\nВведите пятизначное число:");
    N1 = Console.ReadLine();
     N1 = N1.TrimStart(minus);
}
if (N1[0]==N1[3] && N1[1]==N1[4])

    Console.WriteLine("Ваше число полиндром!");

 else

    Console.WriteLine("Ваше число не полиндром!");

