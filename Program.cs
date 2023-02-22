// Учимся работать с многомерными массивами
string [,] table = new string [2,5];
table[1,3] = "слово"; // обращение к конкретному элементу в массиве


int [,] matrix = new int [3,3];


void PrintArray (int[,] array)
{
  for (int rows=0; rows < array.GetLength(0); rows++)
  {
    for (int columns =0; columns<array.GetLength(1); columns++)
    {
      Console.Write($"{array[rows, columns]} ");
    }
    System.Console.WriteLine();
  }
}

void FillArray ( int [,] array)
{
    for (int rows=0; rows < array.GetLength(0); rows++)
  {
    for (int columns =0; columns<array.GetLength(1); columns++)
    {
      array[rows,columns] = new Random().Next(1,10);
    }
  }
}
  

FillArray(matrix);
PrintArray(matrix);

double Facrotial (int num)
{
  if (num == 1 ) return 1;
  else if (num == 0 ) return 1;
  else return (num*Facrotial(num-1)) ;
}

System.Console.WriteLine(Facrotial(2)); 

int Fibonacci (int n)
{
  if (n==1 || n == 2) return 1;
  else return Fibonacci(n-1) + Fibonacci(n-2);
}
for ( int i=1; i<10; i++)
{
System.Console.WriteLine(Fibonacci(i));
}