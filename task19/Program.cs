// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите ваше пятизначное число:");
int[] array = new int[5];
void FillArray( int[] arr)
{
    int x = Convert.ToInt32(Console.ReadLine());
    int index = 0;
    while (x != 0)
    {
        int a = x%10;
        arr[index] = a;
        x = (x-a)/10;
        index++;
    }
}   
 FillArray(array);
 int i = 0;
 if((array[i] == array[i+3])&&(array[i+1] == array[i+2])) Console.WriteLine("Да,палиндром");
 else Console.WriteLine("Нет, не палиндром");
/*void Compare(int[] arr)
{
    for (int i = 0; i < (arr.Length-1)/2; i++)
    {
        int n = arr.Length;
        if (arr[i] == arr[n-1]) n--;
        else 
        {   
            Console.WriteLine("Не палиндром");
            break;
        }
    }
}*/
//Compare(array);