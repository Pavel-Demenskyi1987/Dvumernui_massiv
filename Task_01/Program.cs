

Random random = new Random();

int rows = 3;
int cols = 3;

int[,] array = new int[rows, cols];
for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = random.Next(1, 10); 
        }
    }
for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            System.Console.Write(array[i,j] +" ");
        }
        System.Console.WriteLine();
    }


Console.Write("Введите количество строк: ");
int number1 = int.Parse(Console.ReadLine()!); 
Console.Write("Введите количество столбцов: ");
int number2 = int.Parse(Console.ReadLine()!);
int result = GetElementValue(array, number1, number2);

if (result != int.MinValue)
{
    Console.WriteLine($"Значение элемента в позиции ({number1}, {number2}): {result}");
}
else
{
    Console.WriteLine($"Элемент в позиции ({number1}, {number2}) отсутствует");
}
    

int GetElementValue(int[,] array, int number1, int number2)
{
    
    if (number1 >= 0 && number1 < array.GetLength(0) && number2 >= 0 && number2< array.GetLength(1))
    {   
        return array[number1, number2];
    }
    else
    {
        return int.MinValue;
    }
}
  