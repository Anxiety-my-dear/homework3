Console.WriteLine("Введите два числа");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int i = x;
while(i<y)
{
    int c = i*i*i;
    Console.Write(c+", ");
    i++;
}