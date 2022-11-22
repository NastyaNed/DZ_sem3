// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int Ax = ReadInt("Введите координату X точки A: ");
int Ay = ReadInt("Введите координату Y точки A: ");
int Az = ReadInt("Введите координату Z точки A: ");

int Bx = ReadInt("Введите координату X точки B: ");
int By = ReadInt("Введите координату Y точки B: ");
int Bz = ReadInt("Введите координату Z точки B: ");

int sqrSideX = (Ax - Bx) * (Ax - Bx);
int sqrSideY = (Ay - By) * (Ay - By);
int sqrSideZ = (Az - Bz) * (Az - Bz);
double distance = Math.Sqrt(sqrSideX + sqrSideY + sqrSideZ);
Console.WriteLine(distance);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}