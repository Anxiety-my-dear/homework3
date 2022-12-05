// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//D=sqrt((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2)
void FillArray( int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int x = Convert.ToInt32(Console.ReadLine());
        arr[i] = x;
    }
}

Console.WriteLine("Введите координаты x,y,z первой точки А:");
int[] A = new int[3];
FillArray(A);

Console.WriteLine("Введите координаты x,y,z второй точки B:");
int[] B = new int[3];
FillArray(B);
double S = Math.Sqrt (((B[0]-A[0])*(B[0]-A[0])) + (B[1]-A[1])*(B[1]-A[1]) + (B[2] - A[2])*(B[2] - A[2]));
Console.WriteLine(S);