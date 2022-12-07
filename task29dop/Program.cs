Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int N=Convert.ToInt32(Console.ReadLine());
while(N>1000000 || N<=0)
{
 Console.Write("Введите кол-во элементов от 1 до 10^5: ");
 N=Convert.ToInt32(Console.ReadLine());   
}
int[] array = new int[N];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 101);
}
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.Write("Введите число сдвига: ");
int R=Convert.ToInt32(Console.ReadLine());
while(Math.Abs(R)>1000000)
{
 Console.Write("Введите число сдвига до 10^5 по модулю: ");
 R=Convert.ToInt32(Console.ReadLine());   
}
if (R>0)
{
for (int i = 0; i < R ;i++)
{
    int tmp=array[array.Length-1];
    for (int j = array.Length-1; j >0 ;j--)
            array[j]=array[j-1];
            
    array[0]=tmp;    
}
  Console.WriteLine($"[{string.Join(", ", array)}]");
}
else
{
    R=R*-1;
    for (int i = 0; i < R ;i++)
{
    int tmp=array[0];
    for (int j =0; j <array.Length-1 ;j++)
           { array[j]=array[j+1];
                     
             //Console.WriteLine($"[{string.Join(", ", array)}]");
           }
    array[array.Length-1]=tmp;    
}
  Console.WriteLine($"[{string.Join(", ", array)}]");
}